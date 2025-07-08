using ControlAccesos.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                    TipoHabitante = cmbHabitante.Text
                };

                if (int.TryParse(txtResidenteId.Text, out int resId))
                    request.ResidenteId = resId;

                if (int.TryParse(txtInvitadoId.Text, out int invId))
                    request.InvitadoId = invId;

                if (int.TryParse(txtGuardiaId.Text, out int guaId))
                    request.GuardiaId = guaId;

                
                    request.PlacasVehiculo = txtPlacas.Text;

                if (cmbTipo.SelectedIndex > 0 && cmbTipo.SelectedItem != null)
                    request.TipoAcceso = cmbTipo.SelectedItem.ToString();

                var historial = await _apiClient.PostAsync<AccessHistoryRequest, List<HistorialResponse>>("Acceso/history", request);

                dgvHistorial.AutoGenerateColumns = false;
                dgvHistorial.Columns.Clear();

                if (historial != null && historial.Any())
                {
                    var firstItem = historial.First();
                    var properties = firstItem.GetType().GetProperties();

                    foreach (var prop in properties)
                    {
                        bool allNull = historial.All(h => prop.GetValue(h) == null);
                        if (allNull) continue;
                        var column = new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = prop.Name,
                            Name = prop.Name,
                            HeaderText = prop.Name // Puedes personalizar el HeaderText aquí
                        };
                        dgvHistorial.Columns.Add(column);
                    }

                    dgvHistorial.DataSource = historial;
                }
                else
                {
                    dgvHistorial.DataSource = null;
                    MessageBox.Show("No se encontraron registros con los filtros especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboHabitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void cmbHabitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}