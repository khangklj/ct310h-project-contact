﻿using System.Drawing.Drawing2D;

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
            tsmiAccountDetails = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            rbtnAccount = new RoundButton();
            lblAccountName = new Label();
            pnlMain = new Panel();
            cmsAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rbtnAccount).BeginInit();
            SuspendLayout();
            // 
            // btnManageContact
            // 
            btnManageContact.Location = new Point(15, 32);
            btnManageContact.Margin = new Padding(2);
            btnManageContact.Name = "btnManageContact";
            btnManageContact.Size = new Size(105, 29);
            btnManageContact.TabIndex = 1;
            btnManageContact.Text = "Manage Contact";
            btnManageContact.UseVisualStyleBackColor = true;
            btnManageContact.Click += btnManageContact_Click;
            // 
            // btnManageGroup
            // 
            btnManageGroup.Location = new Point(126, 32);
            btnManageGroup.Margin = new Padding(2);
            btnManageGroup.Name = "btnManageGroup";
            btnManageGroup.Size = new Size(105, 29);
            btnManageGroup.TabIndex = 2;
            btnManageGroup.Text = "Manage Group";
            btnManageGroup.UseVisualStyleBackColor = true;
            btnManageGroup.Click += btnManageGroup_Click;
            // 
            // lblHomePage
            // 
            lblHomePage.AutoSize = true;
            lblHomePage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomePage.Location = new Point(444, 9);
            lblHomePage.Margin = new Padding(2, 0, 2, 0);
            lblHomePage.Name = "lblHomePage";
            lblHomePage.Size = new Size(117, 25);
            lblHomePage.TabIndex = 2;
            lblHomePage.Text = "HOMEPAGE";
            // 
            // cmsAccount
            // 
            cmsAccount.ImageScalingSize = new Size(24, 24);
            cmsAccount.Items.AddRange(new ToolStripItem[] { tsmiAccountDetails, signOutToolStripMenuItem, exitToolStripMenuItem });
            cmsAccount.Name = "contextMenuStrip1";
            cmsAccount.Size = new Size(157, 70);
            // 
            // tsmiAccountDetails
            // 
            tsmiAccountDetails.Name = "tsmiAccountDetails";
            tsmiAccountDetails.Size = new Size(156, 22);
            tsmiAccountDetails.Text = "Account details";
            tsmiAccountDetails.Click += tsmiAccountDetails_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(156, 22);
            signOutToolStripMenuItem.Text = "Sign out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(156, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // rbtnAccount
            // 
            rbtnAccount.BackColor = Color.Transparent;
            rbtnAccount.BorderSize = 2;
            rbtnAccount.CornerRadius = 32;
            rbtnAccount.Image = Properties.Resources._420578901_7242486e_31f0_445b_8413_adec87813679;
            rbtnAccount.Location = new Point(970, 32);
            rbtnAccount.Margin = new Padding(2);
            rbtnAccount.Name = "rbtnAccount";
            rbtnAccount.Size = new Size(45, 38);
            rbtnAccount.SizeMode = PictureBoxSizeMode.Zoom;
            rbtnAccount.TabIndex = 3;
            rbtnAccount.TabStop = false;
            rbtnAccount.Click += rbtnAccount_Click;
            // 
            // lblAccountName
            // 
            lblAccountName.Location = new Point(821, 55);
            lblAccountName.Margin = new Padding(2, 0, 2, 0);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(145, 15);
            lblAccountName.TabIndex = 4;
            lblAccountName.Text = "[Account Name]";
            lblAccountName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(15, 87);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1000, 386);
            pnlMain.TabIndex = 5;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 491);
            Controls.Add(pnlMain);
            Controls.Add(lblAccountName);
            Controls.Add(rbtnAccount);
            Controls.Add(lblHomePage);
            Controls.Add(btnManageGroup);
            Controls.Add(btnManageContact);
            Margin = new Padding(2);
            Name = "frmHomePage";
            Text = "Homepage";
            FormClosed += frmHomePage_FormClosed;
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
        private ToolStripMenuItem tsmiAccountDetails;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RoundButton rbtnAccount;
        private Label lblAccountName;
        private Panel pnlMain;
    }
}