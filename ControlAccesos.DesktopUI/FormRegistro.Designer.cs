namespace ControlAccesos.DesktopUI
{
    partial class FormRegistro
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
            registroControl1 = new RegistroControl();
            SuspendLayout();
            // 
            // registroControl1
            // 
            registroControl1.Location = new Point(12, 12);
            registroControl1.Name = "registroControl1";
            registroControl1.Size = new Size(786, 426);
            registroControl1.TabIndex = 0;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(registroControl1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            ResumeLayout(false);
        }

        #endregion

        private RegistroControl registroControl1;
    }
}