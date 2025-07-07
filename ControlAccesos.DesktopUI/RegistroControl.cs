using ControlAccesos.Core.Models;
using System.Diagnostics;

namespace ControlAccesos.DesktopUI
{
    public partial class RegistroControl : UserControl
    {
        private DataGridViewRow _selectedRow;
        private ApiClient _apiClient = new ApiClient("http://localhost:5295/api/", StaticSession.JwtToken);
        private int residenteId;

        public RegistroControl()
        {
            InitializeComponent();
            btnActualizar.Visible = false;
            btnRegistrar.Visible = true;
            cmbRol.SelectedIndex = 0;
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
                _apiClient.PutAsync<ResidentesPut, Residentes>($"Residentes/{residenteId}", data);
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

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            User data = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = (ERole)cmbRol.SelectedIndex,
                Name = txtNombre.Text,
                LastName = txtApellidos.Text,
                Plate = txtPlacas.Text,
                Address = txtDomicilio.Text,
                Phone = txtTelefono.Text,
                Model = txtVehiculo.Text
            };
            try
            {
                Debug.WriteLine($"Username: {data.Username}");
                Debug.WriteLine($"Password: {data.Password}");
                Debug.WriteLine($"Role: {data.Role}");
                Debug.WriteLine($"Name: {data.Name}");
                Debug.WriteLine($"LastName: {data.LastName}");
                Debug.WriteLine($"Plate: {data.Plate}");
                Debug.WriteLine($"Address: {data.Address}");
                Debug.WriteLine($"Phone: {data.Phone}");
                Debug.WriteLine($"Model: {data.Model}");
                await _apiClient.PostAsync<User>("Account/registerUser", data);
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}