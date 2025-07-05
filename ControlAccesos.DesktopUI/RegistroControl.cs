using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAccesos.DesktopUI
{
    public partial class RegistroControl : UserControl
    {
        public RegistroControl()
        {
            InitializeComponent();
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
