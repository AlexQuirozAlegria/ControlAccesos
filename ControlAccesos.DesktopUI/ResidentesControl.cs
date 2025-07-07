using ControlAccesos.Core.Models;
using System.Diagnostics;

namespace ControlAccesos.DesktopUI
{
    public partial class ResidentesControl : UserControl
    {
        private ApiClient _apiClient;

        public ResidentesControl()
        {
            Debug.WriteLine("La tokeniza: " + StaticSession.JwtToken);
            _apiClient = new ApiClient("http://localhost:5295/api/Residentes/", StaticSession.JwtToken);
            InitializeComponent();
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
            int idParaEditar = 1;
            using (var formRegistro = new FormRegistro())
            {
                var registroControl = new RegistroControl(idParaEditar);
                registroControl.Dock = DockStyle.Fill;

                formRegistro.Text = "Editar Registro";

                formRegistro.Size = new System.Drawing.Size(850, 420);

                formRegistro.Controls.Add(registroControl);

                formRegistro.ShowDialog();
            }
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string name = txtBuscarPorNombre.Text.Trim();
            string address = txtBuscarPorDomicilio.Text.Trim();

            var queryParams = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(name))
            {
                queryParams.Add("name", name);
            }
            if(!string.IsNullOrEmpty(address))
            {
                queryParams.Add("address", address);
            }


            string queryString = ApiClient.BuildQueryString(queryParams);
            List<Residentes>? residentes = await
                _apiClient.GetAsync<List<Residentes>>($"getAllBy?{queryString}");

            foreach (var residente in residentes)
            {
                // Aquí puedes hacer algo con cada residente encontrado, como mostrarlos en un DataGridView
                Debug.WriteLine(residente.ToString());
            }
        }
    }
}
