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
    public partial class AccesoControl : UserControl
    {
        public AccesoControl()
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
