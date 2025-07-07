namespace ControlAccesos.DesktopUI
{
    partial class ResidentesControl
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
            btnNuevoUsuario = new Button();
            dgvResidentes = new DataGridView();
            btnBuscarPorNombre = new Button();
            txtBuscarPorNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBuscarPorDomicilio = new TextBox();
            btnBuscarPorDomicilio = new Button();
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
            btnEditarResidente.Click += btnEditarResidente_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Location = new Point(14, 345);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(166, 29);
            btnNuevoUsuario.TabIndex = 11;
            btnNuevoUsuario.Text = "Nuevo usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // dgvResidentes
            // 
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Location = new Point(14, 98);
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.RowHeadersWidth = 51;
            dgvResidentes.Size = new Size(717, 240);
            dgvResidentes.TabIndex = 10;
            // 
            // btnBuscarPorNombre
            // 
            btnBuscarPorNombre.Location = new Point(637, 13);
            btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            btnBuscarPorNombre.Size = new Size(94, 29);
            btnBuscarPorNombre.TabIndex = 9;
            btnBuscarPorNombre.Text = "Buscar";
            btnBuscarPorNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorNombre
            // 
            txtBuscarPorNombre.Location = new Point(169, 13);
            txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            txtBuscarPorNombre.Size = new Size(462, 27);
            txtBuscarPorNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 7;
            label2.Text = "Buscar por nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 62);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 14;
            label1.Text = "Buscar por domicilio:";
            // 
            // txtBuscarPorDomicilio
            // 
            txtBuscarPorDomicilio.Location = new Point(169, 55);
            txtBuscarPorDomicilio.Name = "txtBuscarPorDomicilio";
            txtBuscarPorDomicilio.Size = new Size(462, 27);
            txtBuscarPorDomicilio.TabIndex = 15;
            // 
            // btnBuscarPorDomicilio
            // 
            btnBuscarPorDomicilio.Location = new Point(637, 53);
            btnBuscarPorDomicilio.Name = "btnBuscarPorDomicilio";
            btnBuscarPorDomicilio.Size = new Size(94, 29);
            btnBuscarPorDomicilio.TabIndex = 16;
            btnBuscarPorDomicilio.Text = "Buscar";
            btnBuscarPorDomicilio.UseVisualStyleBackColor = true;
            // 
            // ResidentesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscarPorDomicilio);
            Controls.Add(txtBuscarPorDomicilio);
            Controls.Add(label1);
            Controls.Add(btnEliminarResidente);
            Controls.Add(btnEditarResidente);
            Controls.Add(btnNuevoUsuario);
            Controls.Add(dgvResidentes);
            Controls.Add(btnBuscarPorNombre);
            Controls.Add(txtBuscarPorNombre);
            Controls.Add(label2);
            Name = "ResidentesControl";
            Size = new Size(770, 403);
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarResidente;
        private Button btnEditarResidente;
        private Button btnNuevoUsuario;
        private DataGridView dgvResidentes;
        private Button btnBuscarPorNombre;
        private TextBox txtBuscarPorNombre;
        private Label label2;
        private Label label1;
        private TextBox txtBuscarPorDomicilio;
        private Button btnBuscarPorDomicilio;
    }
}
