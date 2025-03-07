namespace ct310h_project_contact
{
    partial class frmTestGroupContactManagement
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
            ucContactGroupManagement1 = new ucContactGroupManagement();
            SuspendLayout();
            // 
            // ucContactGroupManagement1
            // 
            ucContactGroupManagement1.Location = new Point(12, 12);
            ucContactGroupManagement1.Name = "ucContactGroupManagement1";
            ucContactGroupManagement1.Size = new Size(1356, 516);
            ucContactGroupManagement1.TabIndex = 0;
            //ucContactGroupManagement1.Load += this.ucContactGroupManagement1_Load;
            // 
            // frmTestGroupContactManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 510);
            Controls.Add(ucContactGroupManagement1);
            Name = "frmTestGroupContactManagement";
            Text = "Contact Group Management";
            ResumeLayout(false);
        }

        #endregion

        private ucContactGroupManagement ucContactGroupManagement1;
    }
}