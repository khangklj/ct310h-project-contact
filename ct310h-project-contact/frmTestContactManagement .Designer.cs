namespace ct310h_project_contact
{
    partial class frmTestContact
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
            ucContactManagement1 = new ucContactManagement();
            SuspendLayout();
            // 
            // ucContactManagement1
            // 
            ucContactManagement1.Location = new Point(6, 2);
            ucContactManagement1.Name = "ucContactManagement1";
            ucContactManagement1.Size = new Size(782, 588);
            ucContactManagement1.TabIndex = 0;
            // 
            // frmTestContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucContactManagement1);
            Name = "frmTestContact";
            Text = "frmTestContact";
            ResumeLayout(false);
        }

        #endregion

        private ucContactManagement ucContactManagement1;
    }
}