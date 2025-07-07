namespace ControlAccesos.DesktopUI
{
    partial class HistorialControl
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
            btnFiltrarHistorial = new Button();
            dgvHistorial = new DataGridView();
            dtpFechaFin = new DateTimePicker();
            label4 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            txtInvitadoID = new TextBox();
            txtResidenteID = new TextBox();
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtGuardiaID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPlacas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrarHistorial
            // 
            btnFiltrarHistorial.Location = new Point(566, 260);
            btnFiltrarHistorial.Margin = new Padding(3, 2, 3, 2);
            btnFiltrarHistorial.Name = "btnFiltrarHistorial";
            btnFiltrarHistorial.Size = new Size(75, 22);
            btnFiltrarHistorial.TabIndex = 11;
            btnFiltrarHistorial.Text = "Filtrar";
            btnFiltrarHistorial.UseVisualStyleBackColor = true;
            btnFiltrarHistorial.Click += btnFiltrarHistorial_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(16, 62);
            dgvHistorial.Margin = new Padding(3, 2, 3, 2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(626, 194);
            dgvHistorial.TabIndex = 10;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(377, 8);
            dtpFechaFin.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(265, 23);
            dtpFechaFin.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 8);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Hasta: ";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(55, 8);
            dtpFechaInicio.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(265, 23);
            dtpFechaInicio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Desde:";
            // 
            // txtInvitadoID
            // 
            txtInvitadoID.Location = new Point(228, 36);
            txtInvitadoID.Margin = new Padding(3, 2, 3, 2);
            txtInvitadoID.Name = "txtInvitadoID";
            txtInvitadoID.Size = new Size(51, 23);
            txtInvitadoID.TabIndex = 12;
            // 
            // txtResidenteID
            // 
            txtResidenteID.Location = new Point(92, 36);
            txtResidenteID.Margin = new Padding(3, 2, 3, 2);
            txtResidenteID.Name = "txtResidenteID";
            txtResidenteID.Size = new Size(51, 23);
            txtResidenteID.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipo.Location = new Point(566, 36);
            cmbTipo.Margin = new Padding(3, 2, 3, 2);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(76, 23);
            cmbTipo.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 15;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 16;
            label2.Text = "Residente ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 38);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 17;
            label5.Text = "Invitado ID:";
            // 
            // txtGuardiaID
            // 
            txtGuardiaID.Location = new Point(361, 36);
            txtGuardiaID.Margin = new Padding(3, 2, 3, 2);
            txtGuardiaID.Name = "txtGuardiaID";
            txtGuardiaID.Size = new Size(51, 23);
            txtGuardiaID.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 38);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 19;
            label6.Text = "Guardia ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 38);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 20;
            label7.Text = "Placas:";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(469, 36);
            txtPlacas.Margin = new Padding(3, 2, 3, 2);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(51, 23);
            txtPlacas.TabIndex = 21;
            // 
            // HistorialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPlacas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtGuardiaID);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(txtResidenteID);
            Controls.Add(txtInvitadoID);
            Controls.Add(btnFiltrarHistorial);
            Controls.Add(dgvHistorial);
            Controls.Add(dtpFechaFin);
            Controls.Add(label4);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HistorialControl";
            Size = new Size(666, 291);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrarHistorial;
        private DataGridView dgvHistorial;
        private DateTimePicker dtpFechaFin;
        private Label label4;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private TextBox txtInvitadoID;
        private TextBox txtResidenteID;
        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtGuardiaID;
        private Label label6;
        private Label label7;
        private TextBox txtPlacas;
    }
}
