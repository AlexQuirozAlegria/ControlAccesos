
using Emgu.CV;
// ZXing.Net namespaces
using ZXing;
using Emgu.CV.CvEnum;




namespace ControlAccesos.DesktopUI
{
    public partial class AccesoControl : UserControl
    {
        private VideoCapture _capture = null;
        private string apiBaseUrl;
        private bool _capturing = false;
        private ZXing.Windows.Compatibility.BarcodeReader barcodeReader;

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
                _capture.Dispose();
                _capture = null;
            }

            if (pictureBoxCamera.Image != null)
            {
                pictureBoxCamera.Image.Dispose();
                pictureBoxCamera.Image = null;
            }

            comboBoxCameras.Enabled = true;
        }

        // --- Evento: Al cerrar el formulario ---
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        // --- Método asíncrono para consumo de la API ---
        private async Task ValidarAccesoConQR(string qrCodeText)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                try
                {
                    string encodedQrCode = Uri.EscapeDataString(qrCodeText);
                    HttpResponseMessage response = await client.GetAsync($"Invitado/validate-qr/{encodedQrCode}");
                    response.EnsureSuccessStatusCode();

                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Respuesta de la API al validar QR: {result}", "Validación API", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }




    }
}
