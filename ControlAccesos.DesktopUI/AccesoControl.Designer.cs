namespace ControlAccesos.DesktopUI
{
    partial class AccesoControl
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
            lblMessage = new Label();
            lblResidente = new Label();
            lblValidez = new Label();
            lblInvitacion = new Label();
            lblName = new Label();
            lblResultado = new Label();
            btnValidacion = new Button();
            btnEntrada = new Button();
            btnSalida = new Button();
            label1 = new Label();
            txtCodigoQR = new TextBox();
            pictureBoxCamera = new PictureBox();
            comboBoxCameras = new ComboBox();
            btnEscanear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMessage);
            groupBox1.Controls.Add(lblResidente);
            groupBox1.Controls.Add(lblValidez);
            groupBox1.Controls.Add(lblInvitacion);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(btnValidacion);
            groupBox1.Controls.Add(btnEntrada);
            groupBox1.Controls.Add(btnSalida);
            groupBox1.Location = new Point(284, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(503, 324);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Acceso";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F);
            lblMessage.Location = new Point(27, 233);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(183, 28);
            lblMessage.TabIndex = 15;
            lblMessage.Text = "Esperando código...";
            // 
            // lblResidente
            // 
            lblResidente.AutoSize = true;
            lblResidente.Font = new Font("Segoe UI", 12F);
            lblResidente.Location = new Point(27, 193);
            lblResidente.Name = "lblResidente";
            lblResidente.Size = new Size(183, 28);
            lblResidente.TabIndex = 14;
            lblResidente.Text = "Esperando código...";
            // 
            // lblValidez
            // 
            lblValidez.AutoSize = true;
            lblValidez.Font = new Font("Segoe UI", 12F);
            lblValidez.Location = new Point(27, 153);
            lblValidez.Name = "lblValidez";
            lblValidez.Size = new Size(183, 28);
            lblValidez.TabIndex = 13;
            lblValidez.Text = "Esperando código...";
            // 
            // lblInvitacion
            // 
            lblInvitacion.AutoSize = true;
            lblInvitacion.Font = new Font("Segoe UI", 12F);
            lblInvitacion.Location = new Point(27, 115);
            lblInvitacion.Name = "lblInvitacion";
            lblInvitacion.Size = new Size(183, 28);
            lblInvitacion.TabIndex = 12;
            lblInvitacion.Text = "Esperando código...";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(27, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(187, 28);
            lblName.TabIndex = 11;
            lblName.Text = "Esperando codigo....";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(27, 36);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(183, 28);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Esperando código...";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnValidacion
            // 
            btnValidacion.Location = new Point(388, 28);
            btnValidacion.Margin = new Padding(3, 4, 3, 4);
            btnValidacion.Name = "btnValidacion";
            btnValidacion.Size = new Size(98, 51);
            btnValidacion.TabIndex = 10;
            btnValidacion.Text = "Validar QR";
            btnValidacion.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSize = true;
            btnEntrada.Location = new Point(173, 280);
            btnEntrada.Margin = new Padding(3, 4, 3, 4);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(149, 36);
            btnEntrada.TabIndex = 7;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.AutoSize = true;
            btnSalida.Location = new Point(337, 280);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(149, 36);
            btnSalida.TabIndex = 8;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 5;
            label1.Text = "Escanear o ingresar Código QR:";
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(514, 40);
            txtCodigoQR.Margin = new Padding(3, 4, 3, 4);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(247, 27);
            txtCodigoQR.TabIndex = 6;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxCamera.Location = new Point(10, 9);
            pictureBoxCamera.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(261, 249);
            pictureBoxCamera.TabIndex = 11;
            pictureBoxCamera.TabStop = false;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(287, 40);
            comboBoxCameras.Margin = new Padding(3, 4, 3, 4);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(220, 28);
            comboBoxCameras.TabIndex = 12;
            // 
            // btnEscanear
            // 
            btnEscanear.Location = new Point(16, 311);
            btnEscanear.Margin = new Padding(3, 4, 3, 4);
            btnEscanear.Name = "btnEscanear";
            btnEscanear.Size = new Size(255, 51);
            btnEscanear.TabIndex = 13;
            btnEscanear.Text = "Iniciar";
            btnEscanear.UseVisualStyleBackColor = true;
            btnEscanear.Click += btnEscanear_Click;
            // 
            // AccesoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEscanear);
            Controls.Add(label1);
            Controls.Add(comboBoxCameras);
            Controls.Add(pictureBoxCamera);
            Controls.Add(groupBox1);
            Controls.Add(txtCodigoQR);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccesoControl";
            Size = new Size(813, 405);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblResultado;
        private Button btnSalida;
        private Button btnEntrada;
        private TextBox txtCodigoQR;
        private Label label1;
        private Button btnValidacion;
        private PictureBox pictureBoxCamera;
        private ComboBox comboBoxCameras;
        private Button btnEscanear;
        private Label lblMessage;
        private Label lblResidente;
        private Label lblValidez;
        private Label lblInvitacion;
        private Label lblName;
    }
}
