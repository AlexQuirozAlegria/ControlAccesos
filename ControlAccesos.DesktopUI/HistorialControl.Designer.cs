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
            btnFiltrar = new Button();
            dgvHistorial = new DataGridView();
            dtpHasta = new DateTimePicker();
            label4 = new Label();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            txtInvitadoId = new TextBox();
            txtResidenteId = new TextBox();
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtGuardiaId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPlacas = new TextBox();
            cmbHabitante = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(647, 347);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 29);
            btnFiltrar.TabIndex = 11;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(18, 82);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(715, 259);
            dgvHistorial.TabIndex = 10;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(431, 10);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(302, 27);
            dtpHasta.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 10);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 8;
            label4.Text = "Hasta: ";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(63, 10);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(302, 27);
            dtpDesde.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Desde:";
            // 
            // txtInvitadoId
            // 
            txtInvitadoId.Location = new Point(260, 49);
            txtInvitadoId.Name = "txtInvitadoId";
            txtInvitadoId.Size = new Size(58, 27);
            txtInvitadoId.TabIndex = 12;
            // 
            // txtResidenteId
            // 
            txtResidenteId.Location = new Point(105, 49);
            txtResidenteId.Name = "txtResidenteId";
            txtResidenteId.Size = new Size(58, 27);
            txtResidenteId.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipo.Location = new Point(647, 48);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(86, 28);
            cmbTipo.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 51);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 15;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 16;
            label2.Text = "Residente ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 51);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 17;
            label5.Text = "Invitado ID:";
            // 
            // txtGuardiaId
            // 
            txtGuardiaId.Location = new Point(413, 48);
            txtGuardiaId.Name = "txtGuardiaId";
            txtGuardiaId.Size = new Size(58, 27);
            txtGuardiaId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 51);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 19;
            label6.Text = "Guardia ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(477, 51);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 20;
            label7.Text = "Placas:";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(536, 48);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(58, 27);
            txtPlacas.TabIndex = 21;
            // 
            // cmbHabitante
            // 
            cmbHabitante.Items.AddRange(new object[] { "Residente", "Invitado" });
            cmbHabitante.Location = new Point(18, 348);
            cmbHabitante.Name = "cmbHabitante";
            cmbHabitante.Size = new Size(121, 28);
            cmbHabitante.TabIndex = 0;
            cmbHabitante.SelectedIndexChanged += cmbHabitante_SelectedIndexChanged;
            // 
            // HistorialControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbHabitante);
            Controls.Add(txtPlacas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtGuardiaId);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(txtResidenteId);
            Controls.Add(txtInvitadoId);
            Controls.Add(btnFiltrar);
            Controls.Add(dgvHistorial);
            Controls.Add(dtpHasta);
            Controls.Add(label4);
            Controls.Add(dtpDesde);
            Controls.Add(label3);
            Name = "HistorialControl";
            Size = new Size(761, 388);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private DataGridView dgvHistorial;
        private DateTimePicker dtpHasta;
        private Label label4;
        private DateTimePicker dtpDesde;
        private Label label3;
        private TextBox txtInvitadoId;
        private TextBox txtResidenteId;
        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtGuardiaId;
        private Label label6;
        private Label label7;
        private TextBox txtPlacas;
        private ComboBox cmbHabitante;
    }
}
