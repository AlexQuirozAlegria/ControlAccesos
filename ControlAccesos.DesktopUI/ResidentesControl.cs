namespace ControlAccesos.DesktopUI
{
    public partial class ResidentesControl : UserControl
    {
        public ResidentesControl()
        {
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
    }
}
