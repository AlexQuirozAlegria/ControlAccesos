namespace ControlAccesos.DesktopUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            lblResultado = new Label();
            btnSalida = new Button();
            btnEntrada = new Button();
            txtCodigoQR = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label2 = new Label();
            txtBuscarResidente = new TextBox();
            btnBuscarResidente = new Button();
            dgvResidentes = new DataGridView();
            btnNuevoResidente = new Button();
            btnEditarResidente = new Button();
            btnEliminarResidente = new Button();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            dgvHistorial = new DataGridView();
            btnFiltrarHistorial = new Button();
            tabControlPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabPage1);
            tabControlPrincipal.Controls.Add(tabPage2);
            tabControlPrincipal.Controls.Add(tabPage3);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(776, 426);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnSalida);
            tabPage1.Controls.Add(btnEntrada);
            tabPage1.Controls.Add(txtCodigoQR);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Acceso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Location = new Point(37, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 181);
            groupBox1.TabIndex = 4;
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
            btnSalida.Location = new Point(176, 81);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(123, 30);
            btnSalida.TabIndex = 3;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSize = true;
            btnEntrada.Location = new Point(37, 81);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(133, 30);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "Registrar Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(271, 22);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(477, 27);
            txtCodigoQR.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 25);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 0;
            label1.Text = "Escanear o ingresar Código QR:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEliminarResidente);
            tabPage2.Controls.Add(btnEditarResidente);
            tabPage2.Controls.Add(btnNuevoResidente);
            tabPage2.Controls.Add(dgvResidentes);
            tabPage2.Controls.Add(btnBuscarResidente);
            tabPage2.Controls.Add(txtBuscarResidente);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Residentes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnFiltrarHistorial);
            tabPage3.Controls.Add(dgvHistorial);
            tabPage3.Controls.Add(dtpFechaFin);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dtpFechaInicio);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Historial";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 0;
            label2.Text = "Buscar Residente:";
            // 
            // txtBuscarResidente
            // 
            txtBuscarResidente.Location = new Point(155, 26);
            txtBuscarResidente.Name = "txtBuscarResidente";
            txtBuscarResidente.Size = new Size(487, 27);
            txtBuscarResidente.TabIndex = 1;
            // 
            // btnBuscarResidente
            // 
            btnBuscarResidente.Location = new Point(648, 26);
            btnBuscarResidente.Name = "btnBuscarResidente";
            btnBuscarResidente.Size = new Size(94, 29);
            btnBuscarResidente.TabIndex = 2;
            btnBuscarResidente.Text = "Buscar";
            btnBuscarResidente.UseVisualStyleBackColor = true;
            // 
            // dgvResidentes
            // 
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Location = new Point(25, 70);
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.RowHeadersWidth = 51;
            dgvResidentes.Size = new Size(717, 281);
            dgvResidentes.TabIndex = 3;
            // 
            // btnNuevoResidente
            // 
            btnNuevoResidente.Location = new Point(25, 358);
            btnNuevoResidente.Name = "btnNuevoResidente";
            btnNuevoResidente.Size = new Size(166, 29);
            btnNuevoResidente.TabIndex = 4;
            btnNuevoResidente.Text = "Nuevo Residente";
            btnNuevoResidente.UseVisualStyleBackColor = true;
            // 
            // btnEditarResidente
            // 
            btnEditarResidente.AutoSize = true;
            btnEditarResidente.Location = new Point(197, 358);
            btnEditarResidente.Name = "btnEditarResidente";
            btnEditarResidente.Size = new Size(166, 30);
            btnEditarResidente.TabIndex = 5;
            btnEditarResidente.Text = "Editar Seleccionado";
            btnEditarResidente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarResidente
            // 
            btnEliminarResidente.AutoSize = true;
            btnEliminarResidente.Location = new Point(369, 357);
            btnEliminarResidente.Name = "btnEliminarResidente";
            btnEliminarResidente.Size = new Size(166, 30);
            btnEliminarResidente.TabIndex = 6;
            btnEliminarResidente.Text = "Eliminar Seleccionado";
            btnEliminarResidente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 20);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "Desde:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(63, 20);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(302, 27);
            dtpFechaInicio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 20);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Hasta: ";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(431, 20);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(302, 27);
            dtpFechaFin.TabIndex = 3;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(18, 88);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(715, 288);
            dgvHistorial.TabIndex = 4;
            // 
            // btnFiltrarHistorial
            // 
            btnFiltrarHistorial.Location = new Point(639, 53);
            btnFiltrarHistorial.Name = "btnFiltrarHistorial";
            btnFiltrarHistorial.Size = new Size(94, 29);
            btnFiltrarHistorial.TabIndex = 5;
            btnFiltrarHistorial.Text = "Filtrar";
            btnFiltrarHistorial.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlPrincipal);
            Name = "FrmPrincipal";
            Text = "Control De Accesos";
            tabControlPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label lblResultado;
        private Button btnSalida;
        private Button btnEntrada;
        private TextBox txtCodigoQR;
        private Label label1;
        private TabPage tabPage3;
        private Button btnEliminarResidente;
        private Button btnEditarResidente;
        private Button btnNuevoResidente;
        private DataGridView dgvResidentes;
        private Button btnBuscarResidente;
        private TextBox txtBuscarResidente;
        private Label label2;
        private DataGridView dgvHistorial;
        private DateTimePicker dtpFechaFin;
        private Label label4;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private Button btnFiltrarHistorial;
    }
}
