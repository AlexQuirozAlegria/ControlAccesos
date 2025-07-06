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
            btnSalida = new Button();
            btnEntrada = new Button();
            txtCodigoQR = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Location = new Point(33, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 181);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Acceso";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(21, 36);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(183, 28);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Esperando código...";
            // 
            // btnSalida
            // 
            btnSalida.AutoSize = true;
            btnSalida.Location = new Point(172, 83);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(123, 30);
            btnSalida.TabIndex = 8;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSize = true;
            btnEntrada.Location = new Point(33, 83);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(133, 30);
            btnEntrada.TabIndex = 7;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(267, 24);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(477, 27);
            txtCodigoQR.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 5;
            label1.Text = "Escanear o ingresar Código QR:";
            // 
            // ResidentesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(txtCodigoQR);
            Controls.Add(label1);
            Name = "ResidentesControl";
            Size = new Size(787, 405);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
