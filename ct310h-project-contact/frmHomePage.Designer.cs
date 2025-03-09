using System.Drawing.Drawing2D;

namespace ct310h_project_contact
{
    partial class frmHomePage
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
            components = new System.ComponentModel.Container();
            btnManageContact = new Button();
            btnManageGroup = new Button();
            lblHomePage = new Label();
            cmsAccount = new ContextMenuStrip(components);
            accountDetailsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            rbtnAccount = new RoundButton();
            lblAccountName = new Label();
            cmsAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rbtnAccount).BeginInit();
            SuspendLayout();
            // 
            // btnManageContact
            // 
            btnManageContact.Location = new Point(22, 54);
            btnManageContact.Name = "btnManageContact";
            btnManageContact.Size = new Size(150, 34);
            btnManageContact.TabIndex = 0;
            btnManageContact.Text = "Manage Contact";
            btnManageContact.UseVisualStyleBackColor = true;
            btnManageContact.Click += btnManageContact_Click;
            // 
            // btnManageGroup
            // 
            btnManageGroup.Location = new Point(22, 97);
            btnManageGroup.Name = "btnManageGroup";
            btnManageGroup.Size = new Size(150, 34);
            btnManageGroup.TabIndex = 1;
            btnManageGroup.Text = "Manage Group";
            btnManageGroup.UseVisualStyleBackColor = true;
            btnManageGroup.Click += btnManageGroup_Click;
            // 
            // lblHomePage
            // 
            lblHomePage.AutoSize = true;
            lblHomePage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomePage.Location = new Point(336, 9);
            lblHomePage.Name = "lblHomePage";
            lblHomePage.Size = new Size(171, 38);
            lblHomePage.TabIndex = 2;
            lblHomePage.Text = "HOMEPAGE";
            // 
            // cmsAccount
            // 
            cmsAccount.ImageScalingSize = new Size(24, 24);
            cmsAccount.Items.AddRange(new ToolStripItem[] { accountDetailsToolStripMenuItem, settingsToolStripMenuItem, signOutToolStripMenuItem, exitToolStripMenuItem });
            cmsAccount.Name = "contextMenuStrip1";
            cmsAccount.Size = new Size(206, 132);
            // 
            // accountDetailsToolStripMenuItem
            // 
            accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            accountDetailsToolStripMenuItem.Size = new Size(205, 32);
            accountDetailsToolStripMenuItem.Text = "Account details";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(205, 32);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(205, 32);
            signOutToolStripMenuItem.Text = "Sign out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(205, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // rbtnAccount
            // 
            rbtnAccount.BackColor = Color.Transparent;
            rbtnAccount.BorderSize = 2;
            rbtnAccount.CornerRadius = 32;
            rbtnAccount.Image = Properties.Resources._420578901_7242486e_31f0_445b_8413_adec87813679;
            rbtnAccount.Location = new Point(846, 54);
            rbtnAccount.Name = "rbtnAccount";
            rbtnAccount.Size = new Size(64, 64);
            rbtnAccount.SizeMode = PictureBoxSizeMode.Zoom;
            rbtnAccount.TabIndex = 3;
            rbtnAccount.TabStop = false;
            rbtnAccount.Click += rbtnAccount_Click;
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Location = new Point(784, 121);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(126, 25);
            lblAccountName.TabIndex = 4;
            lblAccountName.Text = "Account name";
            lblAccountName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 526);
            Controls.Add(lblAccountName);
            Controls.Add(rbtnAccount);
            Controls.Add(lblHomePage);
            Controls.Add(btnManageGroup);
            Controls.Add(btnManageContact);
            Name = "frmHomePage";
            Text = "Homepage";
            cmsAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rbtnAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageContact;
        private Button btnManageGroup;
        private Label lblHomePage;
        private ContextMenuStrip cmsAccount;
        private ToolStripMenuItem accountDetailsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RoundButton rbtnAccount;
        private Label lblAccountName;
    }
}