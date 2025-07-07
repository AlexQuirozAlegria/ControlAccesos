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
    public partial class loginComponente : UserControl
    {
        public bool LoginExitoso { get; private set; } = false;

        public loginComponente()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                this.LoginExitoso = true;
                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
