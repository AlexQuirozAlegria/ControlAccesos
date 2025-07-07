using ControlAccesos.Core.Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ControlAccesos.DesktopUI
{
    public partial class ResidentesControl : UserControl
    {
        private ApiClient _apiClient;
        BindingList<Residentes> residentesList = new BindingList<Residentes>();

        public ResidentesControl()
        {
            InitializeComponent();
            Debug.WriteLine("La tokeniza: " + StaticSession.JwtToken);
            _apiClient = new ApiClient("http://localhost:5295/api/Residentes/", StaticSession.JwtToken);
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvResidentes.Rows.Clear();
            dgvResidentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidentes.MultiSelect = false;
            dgvResidentes.AllowUserToAddRows = false;
            dgvResidentes.AutoGenerateColumns = true;
            dgvResidentes.DataSource = residentesList;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (var formRegistro = new FormRegistro())
            {
                var registroControl = new RegistroControl();

                registroControl.Dock = DockStyle.Fill;

                formRegistro.Text = "Nuevo Registro";

                formRegistro.Size = new System.Drawing.Size(850, 420);

                formRegistro.Controls.Add(registroControl);

                formRegistro.ShowDialog();
            }
        }

        private void btnEditarResidente_Click(object sender, EventArgs e)
        {
            if(dgvResidentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione primero un residente para editar");
                return;
            }
            using (var formRegistro = new FormRegistro())
            {
                DataGridViewRow selectedRow = dgvResidentes.SelectedRows[0];
                var registroControl = new RegistroControl(selectedRow);
                registroControl.Dock = DockStyle.Fill;
                formRegistro.Text = "Editar Registro";
                formRegistro.Size = new System.Drawing.Size(850, 420);
                formRegistro.Controls.Add(registroControl);
                formRegistro.ShowDialog();
            }
            btnBuscarUsuario_Click(sender, e);
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            dgvResidentes.Rows.Clear();
            string name = txtBuscarPorNombre.Text.Trim();
            string address = txtBuscarPorDomicilio.Text.Trim();

            var queryParams = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(name))
            {
                queryParams.Add("nombre", name);
            }
            if(!string.IsNullOrEmpty(address))
            {
                queryParams.Add("domicilio", address);
            }

            Debug.WriteLine(queryParams.Count);
            string queryString = ApiClient.BuildQueryString(queryParams);
            try
            {
                List<Residentes>? residentes = await
                    _apiClient.GetAsync<List<Residentes>>($"getAllBy?{queryString}");
                if(residentes == null)
                {
                    Debug.WriteLine("No se encontraron residentes.");
                    MessageBox.Show("No se encontraron residentes con los criterios de búsqueda proporcionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Debug.WriteLine(residentes.Count);
                residentes.ToList().ForEach(residentesList.Add);
            } catch(HttpRequestException ex)
            {
                Debug.WriteLine($"Error al obtener los residentes: {ex.Message}");
                MessageBox.Show("Error al obtener los residentes. Por favor, intente de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
