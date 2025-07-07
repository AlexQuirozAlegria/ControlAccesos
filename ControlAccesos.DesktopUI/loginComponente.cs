using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAccesos.Core.Models;

namespace ControlAccesos.DesktopUI
{
    public partial class loginComponente : UserControl
    {
        public bool LoginExitoso { get; private set; } = false;

        public loginComponente()
        {
            InitializeComponent();
        }
        private async Task<bool> RealizarLoginAsync(string username, string password)
        {
            var loginRequest = new loginRequest
            {
                Username = username,
                Password = password
            };


            using (var httpClient = new HttpClient())
            {
                string url = "http://localhost:5295/api/Account/login/"; // Cambia la URL por la de tu API real
                var json = JsonSerializer.Serialize(loginRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseBody);

                    Debug.WriteLine("Login response: " + loginResponse.token);
                    Debug.WriteLine("responseBody: " + responseBody.ToString());
                    if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.token))
                    {
                        StaticSession.JwtToken = loginResponse.token;
                        Debug.WriteLine("Tokenwa: " + StaticSession.JwtToken);
                        // Aquí puedes guardar el token en una clase estática o singleton para usarlo en toda la app
                        // Por ejemplo: SessionManager.JwtToken = loginResponse.Token;
                        return true;
                    }
                    return true;
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {

            bool loginOk = await RealizarLoginAsync(txtUsuario.Text, txtPassword.Text);

            if (loginOk)
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
