namespace ControlAccesos.DesktopUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginComponente1 = new loginComponente();
            SuspendLayout();
            // 
            // loginComponente1
            // 
            loginComponente1.Location = new Point(22, 15);
            loginComponente1.Name = "loginComponente1";
            loginComponente1.Size = new Size(534, 322);
            loginComponente1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 320);
            Controls.Add(loginComponente1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
        }

        #endregion

        private loginComponente loginComponente1;
    }
}