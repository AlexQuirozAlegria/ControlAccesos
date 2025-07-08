using ControlAccesos.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlAccesos.DesktopUI
{
    public partial class HistorialControl : UserControl
    {
        private readonly ApiClient _apiClient = new ApiClient("http://localhost:5295/api/", StaticSession.JwtToken);

        public HistorialControl()
        {
            InitializeComponent();
        }

        private void HistorialControl_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            CargarHistorial();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private async void CargarHistorial()
        {
            try
            {
                var request = new AccessHistoryRequest
                {
                    FechaInicio = dtpDesde.Value.Date,
                    FechaFin = dtpHasta.Value.Date.AddDays(1).AddTicks(-1),
                };

                if (!string.IsNullOrWhiteSpace(txtResidenteId.Text) && int.TryParse(txtResidenteId.Text, out int resId))
                    request.ResidenteId = resId;

                if (!string.IsNullOrWhiteSpace(txtInvitadoId.Text) && int.TryParse(txtInvitadoId.Text, out int invId))
                    request.InvitadoId = invId;

                if (!string.IsNullOrWhiteSpace(txtGuardiaId.Text) && int.TryParse(txtGuardiaId.Text, out int guaId))
                    request.GuardiaId = guaId;

                if (!string.IsNullOrWhiteSpace(txtPlacas.Text))
                    request.PlacasVehiculo = txtPlacas.Text;

                if (cmbTipo.SelectedIndex > 0 && cmbTipo.SelectedItem != null)
                    request.TipoAcceso = cmbTipo.SelectedItem.ToString();

                var historial = await _apiClient.PostAsync<AccessHistoryRequest, List<HistorialResponse>>("Acceso/history", request);

                dgvHistorial.DataSource = historial;

                if (dgvHistorial.Columns.Count > 0)
                {
                    dgvHistorial.Columns["FechaHora"].HeaderText = "Fecha y Hora";
                    dgvHistorial.Columns["TipoAcceso"].HeaderText = "Tipo";
                    dgvHistorial.Columns["NombrePersona"].HeaderText = "Quién Entró/Salió";
                    dgvHistorial.Columns["Rol"].HeaderText = "Rol";
                    dgvHistorial.Columns["InvitadoPor"].HeaderText = "Invitado Por";
                    dgvHistorial.Columns["Guardia"].HeaderText = "Guardia que Registró";
                    dgvHistorial.Columns["Placas"].HeaderText = "Placas";

                    dgvHistorial.Columns["FechaHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvHistorial.Columns["NombrePersona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvHistorial.Columns["InvitadoPor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if (historial == null || !historial.Any())
                {
                    MessageBox.Show("No se encontraron registros con los filtros especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}