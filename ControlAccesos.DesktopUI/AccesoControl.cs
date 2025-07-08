using Emgu.CV;
// ZXing.Net namespaces
using ZXing;
using Emgu.CV.CvEnum;
using ControlAccesos.Core.Models;
using System.Diagnostics;

namespace ControlAccesos.DesktopUI
{
    public partial class AccesoControl : UserControl
    {
        private VideoCapture _capture = null;
        private string apiBaseUrl;
        private bool _capturing = false;
        private ZXing.Windows.Compatibility.BarcodeReader barcodeReader;
        private ApiClient _apiClient = new ApiClient("http://localhost:5295/api/", StaticSession.JwtToken);
        private AccessResponse lastUsed;
        private QR invitado;
        private string code;
        private Residentes currentResidente;

        public AccesoControl()
        {
            InitializeComponent();
            InitializeQRScannerComponents();
            apiBaseUrl = "http://localhost:5295/api/";
        }

        private void InitializeQRScannerComponents()
        {
            barcodeReader = new ZXing.Windows.Compatibility.BarcodeReader();
            barcodeReader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE };
            barcodeReader.Options.TryHarder = true;
            barcodeReader.Options.PureBarcode = false;

            comboBoxCameras.Items.Add("Cámara por defecto (0)");
            if (comboBoxCameras.Items.Count > 0)
            {
                comboBoxCameras.SelectedIndex = 0; // Seleccionar la primera cámara
            }

            // Configuración inicial del botón
            btnEscanear.Text = "Iniciar Escaneo"; // Asigna el texto inicial a el botón "Escanear"
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if (_capturing)
            {
                // Si está capturando, detener
                StopCapture();
                btnEscanear.Text = "Iniciar Escaneo";
                txtCodigoQR.Text = "Escaneo detenido.";
            }
            else
            {
                // Si no está capturando, iniciar
                StartCapture();
                btnEscanear.Text = "Detener Escaneo";
                txtCodigoQR.Text = "Escaneando QR...";
            }
        }

        private void StartCapture()
        {
            if (comboBoxCameras.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una cámara.", "Cámara no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cameraIndex = comboBoxCameras.SelectedIndex;

            try
            {
                StopCapture(); //  Detener cualquier captura anterior
                _capture = new VideoCapture(cameraIndex);
                _capture.ImageGrabbed += ProcessFrameAsync;
                _capture.Start();

                _capturing = true;
                comboBoxCameras.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la cámara: {ex.Message}", "Error de Cámara", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopCapture(); // Limpiar si hay un error
            }
        }

        // --- Método asíncrono que procesa cada fotograma de la cámara ---
        private async void ProcessFrameAsync(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                using (Mat frame = new Mat())
                {
                    _capture.Retrieve(frame);

                    if (frame.IsEmpty) return;

                    // Convertir el Mat a Bitmap para mostrar en PictureBox
                    Bitmap originalBitmap = frame.ToBitmap();

                    using (Bitmap bitmapForDecoding = new Bitmap(originalBitmap))
                    {
                        if (pictureBoxCamera.InvokeRequired)
                        {
                            pictureBoxCamera.Invoke(new MethodInvoker(delegate
                            {
                                if (pictureBoxCamera.Image != null)
                                {
                                    pictureBoxCamera.Image.Dispose();
                                }
                                pictureBoxCamera.Image = originalBitmap; // Asigna el Bitmap original
                            }));
                        }
                        else
                        {
                            if (pictureBoxCamera.Image != null)
                            {
                                pictureBoxCamera.Image.Dispose();
                            }
                            pictureBoxCamera.Image = originalBitmap;
                        }

                        // Ejecutar la decodificación en un hilo de fondo usando la COPIA del Bitmap
                        string qrText = await Task.Run(() =>
                        {
                            try
                            {
                                Result result = barcodeReader.Decode(bitmapForDecoding);
                                return result?.Text;
                            }
                            catch (Exception exDecode)
                            {
                                Console.WriteLine($"Error al decodificar QR en Task.Run: {exDecode.Message}");
                                return null; // Retorna null si hay un error de decodificación
                            }
                        });

                        if (!string.IsNullOrEmpty(qrText))
                        {
                            // QR encontrado, detener la cámara y mostrar el resultado
                            StopCapture(); // Detener la captura inmediatamente
                            btnEscanear.Invoke(new Action(() => btnEscanear.Text = "Iniciar Escaneo")); // Actualizar texto del botón

                            if (InvokeRequired)
                            {
                                Invoke(new MethodInvoker(async delegate
                                {
                                    txtCodigoQR.Text = qrText;
                                    MessageBox.Show($"QR Escaneado: {qrText}", "QR Detectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    await ValidarAccesoConQR(qrText);
                                }));
                            }
                            else
                            {
                                txtCodigoQR.Text = qrText;
                                MessageBox.Show($"QR Escaneado: {qrText}", "QR Detectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await ValidarAccesoConQR(qrText);
                            }
                        }
                    }
                }
            }
        }

        // --- Método auxiliar para detener la captura de video ---
        private void StopCapture()
        {
            if (_capture != null)
            {
                if (_capturing)
                {
                    _capture.Stop();
                    _capture.ImageGrabbed -= ProcessFrameAsync;
                    _capturing = false;
                }
                if (_capture != null)
                {
                    _capture.Dispose();
                }
                _capture = null;
            }

            if (pictureBoxCamera.Image != null)
            {
                pictureBoxCamera.Image.Dispose();
                pictureBoxCamera.Image = null;
            }

            if (comboBoxCameras.InvokeRequired)
            {
                comboBoxCameras.Invoke(new MethodInvoker(delegate
                {
                    comboBoxCameras.Enabled = true;
                }));
            }
            else
            {
                comboBoxCameras.Enabled = true;
            }
        }

        // --- Evento: Al cerrar el formulario ---
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        // --- Método asíncrono para consumo de la API ---
        private async Task ValidarAccesoConQR(string qrCodeText)
        {
            try
            {
                string encodedQrCode = Uri.EscapeDataString(qrCodeText);
                QR response = await _apiClient.GetAsync<QR>($"Invitado/validate-qr/{encodedQrCode}");
                invitado = response;
                setData(response);
                lastUsed = await getLastTimestamp(response);
                if (lastUsed != null)
                {
                    if (lastUsed.state == EState.Entrada)
                    {
                        btnEntrada.Enabled = false;
                        btnSalida.Enabled = true;
                    }
                    else
                    {
                        btnEntrada.Enabled = true;
                        btnSalida.Enabled = false;
                    }
                }
                else
                {
                    Debug.WriteLine("No se encontraron registros previos para este QR.");
                    btnEntrada.Enabled = true;
                    btnSalida.Enabled = false;
                }
                code = qrCodeText;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al llamar a la API: {ex.Message}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al validar QR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<AccessResponse> getLastTimestamp(QR invitado)
        {
            if(invitado == null)
            {
                Debug.WriteLine("No hay invitado");
                return null;
            }
            AccessRequest request = new AccessRequest
            {
                GuestId = invitado.Id
            };
            List<AccessResponse>? allData = await
                _apiClient.PostAsync<AccessRequest, List<AccessResponse>>("Acceso/history", request);

            if (allData != null && allData.Count > 0)
            {
                AccessResponse lastRecord = allData.OrderByDescending(r => r.datetime).FirstOrDefault();
                Debug.WriteLine($"Último registro: {lastRecord?.datetime} - Estado: {lastRecord?.state}");
                return lastRecord;
            }
            else
            {
                return null;
            }
        }

        private void setData(QR invitado)
        {
            if (invitado != null)
            {
                lblName.Text = $"{invitado.Name} {invitado.LastName}";
                lblInvitacion.Text = invitado.Type.ToString();
                lblValidez.Text = invitado.date.HasValue ? invitado.date.Value.ToString("dd/MM/yyyy") : "Indefinido";
                lblResidente.Text = invitado.Host;
                lblMessage.Text = invitado.Message;
            }
            else
            {
                MessageBox.Show("No se encontró información del invitado.", "Información no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (invitado != null)
            {
                RegisterAccessRequest request = new RegisterAccessRequest
                {
                    qrcode = code,
                    state = EState.Entrada
                };
                _apiClient.PostAsync<RegisterAccessRequest, AccessResponse>("Acceso/register", request)
                    .ContinueWith(task =>
                    {
                        if (task.IsCompletedSuccessfully)
                        {
                            AccessResponse response = task.Result;
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show($"Entrada registrada: {response.datetime}", "Entrada Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnEntrada.Enabled = false;
                                btnSalida.Enabled = true;
                            });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Error al registrar la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });
                        }
                    });
            } else if(currentResidente != null)
            {
                RegisterAccessRequest request = new RegisterAccessRequest
                {
                    residentUsername = txtCodigoQR.Text,
                    state = EState.Entrada
                };
                _apiClient.PostAsync<RegisterAccessRequest, AccessResponse>("Acceso/register", request)
                    .ContinueWith(task =>
                    {
                        if (task.IsCompletedSuccessfully)
                        {
                            AccessResponse response = task.Result;
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show($"Entrada registrada: {response.datetime}", "Entrada Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnEntrada.Enabled = false;
                                btnSalida.Enabled = true;
                            });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Error al registrar la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });
                        }
                    });
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (invitado != null)
            {
                RegisterAccessRequest request = new RegisterAccessRequest
                {
                    qrcode = code,
                    state = EState.Salida
                };
                _apiClient.PostAsync<RegisterAccessRequest, AccessResponse>("Acceso/register", request)
                    .ContinueWith(task =>
                    {
                        if (task.IsCompletedSuccessfully)
                        {
                            AccessResponse response = task.Result;
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show($"Salida registrada: {response.datetime}", "Entrada Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnEntrada.Enabled = true;
                                btnSalida.Enabled = false;
                            });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Error al registrar la salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });
                        }
                    });
            } else if(currentResidente != null)
            {
                RegisterAccessRequest request = new RegisterAccessRequest
                {
                    residentUsername = txtCodigoQR.Text,
                    state = EState.Salida
                };
                _apiClient.PostAsync<RegisterAccessRequest, AccessResponse>("Acceso/register", request)
                    .ContinueWith(task =>
                    {
                        if (task.IsCompletedSuccessfully)
                        {
                            AccessResponse response = task.Result;
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show($"Salida registrada: {response.datetime}", "Salida Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnEntrada.Enabled = true;
                                btnSalida.Enabled = false;
                            });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Error al registrar la salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            });
                        }
                    });
            }
        }

        private async Task<AccessResponse> getLastTimestamp(int id)
        {
            AccessRequest request = new AccessRequest
            {
                ResidentId = id
            };
            List<AccessResponse>? allData = await
                _apiClient.PostAsync<AccessRequest, List<AccessResponse>>("Acceso/history", request);

            if (allData != null && allData.Count > 0)
            {
                AccessResponse lastRecord = allData.OrderByDescending(r => r.datetime).FirstOrDefault();
                Debug.WriteLine($"Último registro: {lastRecord?.datetime} - Estado: {lastRecord?.state}");
                return lastRecord;
            }
            else
            {
                return null;
            }
        }

        private async void btnValidacion_Click(object sender, EventArgs e)
        {
            string value = txtCodigoQR.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Por favor, escanee o ingrese un codigo primero.", "Código QR no escaneado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ResidentesByUsernameResponse? responseRes = await
                    _apiClient.GetAsync<ResidentesByUsernameResponse>($"Residentes/byUsername?username={value}");
                if (responseRes == null)
                {
                    Debug.WriteLine("Esto no debe pasar si no es QR");   
                    await ValidarAccesoConQR(value);
                }
                else
                {
                    int id = responseRes.Id;
                    Residentes? user = await
                        _apiClient.GetAsync<Residentes>($"Residentes/{id}");
                    setValuesByResidentes(user);
                    lastUsed = await getLastTimestamp(user.Id);
                    currentResidente = user;
                    if (lastUsed != null)
                    {
                        if (lastUsed.state == EState.Entrada)
                        {
                            btnEntrada.Enabled = false;
                            btnSalida.Enabled = true;
                        }
                        else
                        {
                            btnEntrada.Enabled = true;
                            btnSalida.Enabled = false;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("No se encontraron registros previos para este residente.");
                        btnEntrada.Enabled = true;
                        btnSalida.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar el código QR: {ex.Message}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setValuesByResidentes(Residentes residente)
        {
            if (residente != null)
            {
                lblName.Text = $"{residente.Name} {residente.LastName}";
            }
            else
            {
                MessageBox.Show("No se encontró información del residente.", "Información no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
