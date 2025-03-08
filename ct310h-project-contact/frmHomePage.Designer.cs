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
            rbtnAccount = new RJControls.RJButton();
            cmsAccount.SuspendLayout();
            SuspendLayout();
            // 
            // btnManageContact
            // 
            btnManageContact.Location = new Point(22, 82);
            btnManageContact.Name = "btnManageContact";
            btnManageContact.Size = new Size(150, 34);
            btnManageContact.TabIndex = 0;
            btnManageContact.Text = "Manage Contact";
            btnManageContact.UseVisualStyleBackColor = true;
            btnManageContact.Click += btnManageContact_Click;
            // 
            // btnManageGroup
            // 
            btnManageGroup.Location = new Point(22, 141);
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
            lblHomePage.Location = new Point(277, 9);
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
            rbtnAccount.BackColor = Color.MediumSlateBlue;
            rbtnAccount.BackgroundColor = Color.MediumSlateBlue;
            rbtnAccount.BorderColor = Color.PaleVioletRed;
            rbtnAccount.BorderRadius = 32;
            rbtnAccount.BorderSize = 0;
            rbtnAccount.FlatAppearance.BorderSize = 0;
            rbtnAccount.FlatStyle = FlatStyle.Flat;
            rbtnAccount.ForeColor = Color.White;
            rbtnAccount.HoverColor = Color.FromArgb(100, 128, 128, 128);
            rbtnAccount.Location = new Point(699, 67);
            rbtnAccount.Name = "rbtnAccount";
            rbtnAccount.Size = new Size(64, 64);
            rbtnAccount.TabIndex = 4;
            rbtnAccount.Text = "Avatar";
            rbtnAccount.TextColor = Color.White;
            rbtnAccount.UseVisualStyleBackColor = false;
            rbtnAccount.Click += rbtnAccount_Click;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtnAccount);
            Controls.Add(lblHomePage);
            Controls.Add(btnManageGroup);
            Controls.Add(btnManageContact);
            Name = "frmHomePage";
            Text = "Homepage";
            cmsAccount.ResumeLayout(false);
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
        private RJControls.RJButton rbtnAccount;
    }
}