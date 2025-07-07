using System.Text;
using System.Text.Json;
using ControlAccesos.Core.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ControlAccesos.DesktopUI
{
    public partial class HistorialControl : UserControl
    {
        public HistorialControl()
        {
            InitializeComponent();
        }

        private async void btnFiltrarHistorial_Click(object sender, EventArgs e)
        {
            ApiClient apiClient = new ApiClient("http://localhost:5000/api/", StaticSession.JwtToken);
            var historialRequest = new HistorialRequest
            {
                fechaInicio= dtpFechaInicio.Value,
                fechaFin = dtpFechaFin.Value,
                residenteId = string.IsNullOrEmpty(txtResidenteID.Text) ? null : (int?)int.Parse(txtResidenteID.Text),
                invitadoId = string.IsNullOrEmpty(txtInvitadoID.Text) ? null : (int?)int.Parse(txtInvitadoID.Text),
                tipoAcceso = string.IsNullOrEmpty(cmbTipo.Text) ? null : cmbTipo.Text,
                guardiaId = string.IsNullOrEmpty(txtGuardiaID.Text) ? null : (int?)int.Parse(txtGuardiaID.Text),
                placasVehiculo = string.IsNullOrEmpty(txtPlacas.Text) ? null : txtPlacas.Text
            };
            try
            {
                var result = await apiClient.PostAsync<HistorialRequest, List<HistorialResponse>>("acceso/history", historialRequest);

                if (result != null && result.Any())
                {
                    dgvHistorial.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
