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
            btnEliminarResidente = new Button();
            btnEditarResidente = new Button();
            btnNuevoResidente = new Button();
            dgvResidentes = new DataGridView();
            btnBuscarResidente = new Button();
            txtBuscarResidente = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarResidente
            // 
            btnEliminarResidente.AutoSize = true;
            btnEliminarResidente.Location = new Point(358, 344);
            btnEliminarResidente.Name = "btnEliminarResidente";
            btnEliminarResidente.Size = new Size(166, 30);
            btnEliminarResidente.TabIndex = 13;
            btnEliminarResidente.Text = "Eliminar Seleccionado";
            btnEliminarResidente.UseVisualStyleBackColor = true;
            // 
            // btnEditarResidente
            // 
            btnEditarResidente.AutoSize = true;
            btnEditarResidente.Location = new Point(186, 345);
            btnEditarResidente.Name = "btnEditarResidente";
            btnEditarResidente.Size = new Size(166, 30);
            btnEditarResidente.TabIndex = 12;
            btnEditarResidente.Text = "Editar Seleccionado";
            btnEditarResidente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoResidente
            // 
            btnNuevoResidente.Location = new Point(14, 345);
            btnNuevoResidente.Name = "btnNuevoResidente";
            btnNuevoResidente.Size = new Size(166, 29);
            btnNuevoResidente.TabIndex = 11;
            btnNuevoResidente.Text = "Nuevo Residente";
            btnNuevoResidente.UseVisualStyleBackColor = true;
            // 
            // dgvResidentes
            // 
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Location = new Point(14, 57);
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.RowHeadersWidth = 51;
            dgvResidentes.Size = new Size(717, 281);
            dgvResidentes.TabIndex = 10;
            // 
            // btnBuscarResidente
            // 
            btnBuscarResidente.Location = new Point(637, 13);
            btnBuscarResidente.Name = "btnBuscarResidente";
            btnBuscarResidente.Size = new Size(94, 29);
            btnBuscarResidente.TabIndex = 9;
            btnBuscarResidente.Text = "Buscar";
            btnBuscarResidente.UseVisualStyleBackColor = true;
            // 
            // txtBuscarResidente
            // 
            txtBuscarResidente.Location = new Point(144, 13);
            txtBuscarResidente.Name = "txtBuscarResidente";
            txtBuscarResidente.Size = new Size(487, 27);
            txtBuscarResidente.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 7;
            label2.Text = "Buscar Residente:";
            // 
            // AccesoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEliminarResidente);
            Controls.Add(btnEditarResidente);
            Controls.Add(btnNuevoResidente);
            Controls.Add(dgvResidentes);
            Controls.Add(btnBuscarResidente);
            Controls.Add(txtBuscarResidente);
            Controls.Add(label2);
            Name = "AccesoControl";
            Size = new Size(770, 403);
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarResidente;
        private Button btnEditarResidente;
        private Button btnNuevoResidente;
        private DataGridView dgvResidentes;
        private Button btnBuscarResidente;
        private TextBox txtBuscarResidente;
        private Label label2;
    }
}
