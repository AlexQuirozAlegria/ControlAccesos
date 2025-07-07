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
            lblResultado = new Label();
            label1 = new Label();
            btnSalida = new Button();
            btnEntrada = new Button();
            txtCodigoQR = new TextBox();
            btnValidacion = new Button();
            pictureBoxCamera = new PictureBox();
            comboBoxCameras = new ComboBox();
            btnEscanear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Location = new Point(242, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 268);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Acceso";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(24, 31);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(169, 25);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Esperando código...";
            lblResultado.Click += lblResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 8);
            label1.Name = "label1";
            label1.Size = new Size(196, 17);
            label1.TabIndex = 5;
            label1.Text = "Escanear o ingresar Código QR:";
            // 
            // btnSalida
            // 
            btnSalida.AutoSize = true;
            btnSalida.Location = new Point(106, 283);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(130, 43);
            btnSalida.TabIndex = 8;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSize = true;
            btnEntrada.Location = new Point(106, 234);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(130, 43);
            btnEntrada.TabIndex = 7;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(444, 30);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(217, 25);
            txtCodigoQR.TabIndex = 6;
            // 
            // btnValidacion
            // 
            btnValidacion.Location = new Point(8, 283);
            btnValidacion.Name = "btnValidacion";
            btnValidacion.Size = new Size(91, 39);
            btnValidacion.TabIndex = 10;
            btnValidacion.Text = "Validar QR";
            btnValidacion.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxCamera.Location = new Point(3, 3);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(228, 212);
            pictureBoxCamera.TabIndex = 11;
            pictureBoxCamera.TabStop = false;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(245, 30);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(193, 25);
            comboBoxCameras.TabIndex = 12;
            // 
            // btnEscanear
            // 
            btnEscanear.Location = new Point(12, 238);
            btnEscanear.Name = "btnEscanear";
            btnEscanear.Size = new Size(87, 39);
            btnEscanear.TabIndex = 13;
            btnEscanear.Text = "Escanear";
            btnEscanear.UseVisualStyleBackColor = true;
            btnEscanear.Click += btnEscanear_Click;
            // 
            // AccesoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEscanear);
            Controls.Add(label1);
            Controls.Add(comboBoxCameras);
            Controls.Add(pictureBoxCamera);
            Controls.Add(btnValidacion);
            Controls.Add(groupBox1);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(txtCodigoQR);
            Name = "AccesoControl";
            Size = new Size(689, 344);
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
    }
}
