using ControlAccesos.Core.Models;

namespace ControlAccesos.DesktopUI
{
    public partial class RegistroControl : UserControl
    {
        private DataGridViewRow _selectedRow;
        private ApiClient _apiClient = new ApiClient("http://localhost:5295/api/Residentes/", StaticSession.JwtToken);
        private int residenteId;

        public RegistroControl()
        {
            InitializeComponent();
            btnActualizar.Visible = false;
            btnRegistrar.Visible = true;
        }

        public RegistroControl(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            _selectedRow = selectedRow;
            btnActualizar.Visible = true;
            btnRegistrar.Visible = false;
            groupBox1.Visible = false;
            cmbRol.Visible = false;
            label3.Visible = false;
            residenteId = Convert.ToInt32(_selectedRow.Cells["Id"].Value);
            setValues();
        }

        private void setValues()
        {
            txtNombre.Text = _selectedRow.Cells["Name"].Value.ToString();
            txtApellidos.Text = _selectedRow.Cells["LastName"].Value.ToString();
            txtDomicilio.Text = _selectedRow.Cells["Address"].Value.ToString();
            txtTelefono.Text = _selectedRow.Cells["Phone"].Value.ToString();
            txtVehiculo.Text = _selectedRow.Cells["Model"].Value.ToString();
            txtPlacas.Text = _selectedRow.Cells["Plate"].Value.ToString();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupBoxResidente = this.Controls.Find("groupBox3", true).FirstOrDefault();

            if (groupBoxResidente != null)
            {
                if (cmbRol.SelectedItem.ToString() == "Residente")
                {
                    groupBoxResidente.Visible = true;
                }
                else
                {
                    groupBoxResidente.Visible = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            ResidentesPut data = new ResidentesPut
            {
                Name = txtNombre.Text,
                LastName = txtApellidos.Text,
                Address = txtDomicilio.Text,
                Phone = txtTelefono.Text,
                Model = txtVehiculo.Text,
                Plate = txtPlacas.Text
            };
            Residentes? response = await
                _apiClient.PutAsync<ResidentesPut, Residentes>($"{residenteId}", data);
            if (response != null)
            {
                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}