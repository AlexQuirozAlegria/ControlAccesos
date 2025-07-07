using System;
using System.Windows.Forms;
using ControlAccesos.DesktopUI; // Esta es la línea que se añadió

namespace ControlAccesos.DesktopUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginComponente = new loginComponente();

            using (var loginHostForm = new Form())
            {
                loginHostForm.Text = "Inicio de Sesion";
                loginHostForm.StartPosition = FormStartPosition.CenterScreen;
                loginHostForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                loginHostForm.Controls.Add(loginComponente);
                loginHostForm.AutoSize = true;
                loginHostForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                loginHostForm.ShowDialog();

                if (loginComponente.LoginExitoso)
                {
                    Application.Run(new FrmPrincipal());
                }
            }
        }
    }
}