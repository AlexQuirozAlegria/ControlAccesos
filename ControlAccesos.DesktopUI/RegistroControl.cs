namespace ControlAccesos.DesktopUI
{
    public partial class RegistroControl : UserControl
    {
        private int? _residenteId;

        public RegistroControl(int? residenteId = null)
        {
            InitializeComponent();
            _residenteId = residenteId;

            if (_residenteId.HasValue)
            {
                btnActualizar.Visible = true;
                btnRegistrar.Visible = false;
            }
            else
            {
                btnActualizar.Visible = false;
                btnRegistrar.Visible = true;
            }
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
    }
}