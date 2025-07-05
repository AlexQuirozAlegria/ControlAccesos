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
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrarHistorial
            // 
            btnFiltrarHistorial.Location = new Point(639, 43);
            btnFiltrarHistorial.Name = "btnFiltrarHistorial";
            btnFiltrarHistorial.Size = new Size(94, 29);
            btnFiltrarHistorial.TabIndex = 11;
            btnFiltrarHistorial.Text = "Filtrar";
            btnFiltrarHistorial.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(18, 78);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(715, 288);
            dgvHistorial.TabIndex = 10;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(431, 10);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(302, 27);
            dtpFechaFin.TabIndex = 9;
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
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(63, 10);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(302, 27);
            dtpFechaInicio.TabIndex = 7;
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
            // HistorialControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFiltrarHistorial);
            Controls.Add(dgvHistorial);
            Controls.Add(dtpFechaFin);
            Controls.Add(label4);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label3);
            Name = "HistorialControl";
            Size = new Size(761, 388);
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
    }
}
