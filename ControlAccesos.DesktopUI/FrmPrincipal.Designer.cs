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
            residentesControl1 = new ResidentesControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            historialControl1 = new HistorialControl();
            accesoControl1 = new AccesoControl();
            tabControlPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabPage1);
            tabControlPrincipal.Controls.Add(tabPage2);
            tabControlPrincipal.Controls.Add(tabPage3);
            tabControlPrincipal.Location = new Point(13, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(776, 426);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(residentesControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Acceso";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // residentesControl1
            // 
            residentesControl1.Location = new Point(6, 6);
            residentesControl1.Name = "residentesControl1";
            residentesControl1.Size = new Size(756, 384);
            residentesControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(accesoControl1);
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
            tabPage3.Controls.Add(historialControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Historial";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // historialControl1
            // 
            historialControl1.Location = new Point(5, 4);
            historialControl1.Name = "historialControl1";
            historialControl1.Size = new Size(747, 374);
            historialControl1.TabIndex = 0;
            // 
            // accesoControl1
            // 
            accesoControl1.Location = new Point(6, 6);
            accesoControl1.Name = "accesoControl1";
            accesoControl1.Size = new Size(755, 384);
            accesoControl1.TabIndex = 0;
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
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ResidentesControl residentesControl1;
        private HistorialControl historialControl1;
        private AccesoControl accesoControl1;
    }
}
