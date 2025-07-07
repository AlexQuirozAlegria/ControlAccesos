namespace ControlAccesos.DesktopUI
{
    partial class RegistroControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            groupBox2 = new GroupBox();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cmbRol = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txtPlacas = new TextBox();
            txtVehiculo = new TextBox();
            txtTelefono = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtDomicilio = new TextBox();
            label6 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            btnActualizar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(25, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Acceso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 27);
            txtUsername.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtApellidos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbRol);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(25, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Personal";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(90, 122);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(203, 27);
            txtApellidos.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 122);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 27);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 82);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Residente", "Guardia" });
            cmbRol.Location = new Point(57, 37);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(236, 28);
            cmbRol.TabIndex = 1;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 37);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 0;
            label3.Text = "Rol:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPlacas);
            groupBox3.Controls.Add(txtVehiculo);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDomicilio);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(340, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 318);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles del Residente";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(19, 270);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(252, 27);
            txtPlacas.TabIndex = 7;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(19, 199);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(252, 27);
            txtVehiculo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(19, 120);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 27);
            txtTelefono.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 247);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 4;
            label9.Text = "Placas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 176);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 3;
            label8.Text = "Vehículo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 100);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 2;
            label7.Text = "Teléfono:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(19, 50);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(252, 27);
            txtDomicilio.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 27);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 0;
            label6.Text = "Domicilio:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(634, 258);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(634, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(634, 214);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(145, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // RegistroControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistroControl";
            Size = new Size(782, 351);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsername;
        private GroupBox groupBox2;
        private TextBox txtApellidos;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cmbRol;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox txtPlacas;
        private TextBox txtVehiculo;
        private TextBox txtTelefono;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtDomicilio;
        private Label label6;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnActualizar;
    }
}
