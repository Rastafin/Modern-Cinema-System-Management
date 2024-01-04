﻿namespace GUI
{
    partial class AdminPanelStatistics
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
            panel1 = new Panel();
            labelAdminPanel = new Label();
            buttonStatistics = new Button();
            buttonUsers = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelAdminPanel);
            panel1.Controls.Add(buttonStatistics);
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 7;
            // 
            // labelAdminPanel
            // 
            labelAdminPanel.AutoSize = true;
            labelAdminPanel.BackColor = Color.Coral;
            labelAdminPanel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdminPanel.ForeColor = Color.Black;
            labelAdminPanel.Location = new Point(5, 139);
            labelAdminPanel.Name = "labelAdminPanel";
            labelAdminPanel.Size = new Size(207, 40);
            labelAdminPanel.TabIndex = 9;
            labelAdminPanel.Text = "ADMIN PANEL";
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = Color.Coral;
            buttonStatistics.FlatAppearance.BorderColor = Color.Black;
            buttonStatistics.FlatAppearance.BorderSize = 2;
            buttonStatistics.FlatStyle = FlatStyle.Flat;
            buttonStatistics.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonStatistics.Location = new Point(12, 319);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(200, 56);
            buttonStatistics.TabIndex = 10;
            buttonStatistics.Text = "STATISTICS";
            buttonStatistics.UseVisualStyleBackColor = false;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.Coral;
            buttonUsers.FlatAppearance.BorderColor = Color.Black;
            buttonUsers.FlatAppearance.BorderSize = 2;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUsers.Location = new Point(12, 227);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(200, 56);
            buttonUsers.TabIndex = 9;
            buttonUsers.Text = "USERS";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4170e6ab0f6d30dca42c2df7cf52fb999351cb63d11203175d4ddb638955e9c2;
            pictureBox1.Location = new Point(42, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Coral;
            buttonBack.FlatAppearance.BorderColor = Color.Black;
            buttonBack.FlatAppearance.BorderSize = 2;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 1044);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(200, 56);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // AdminPanelStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanelStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanelStatistics";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanelStatistics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelAdminPanel;
        private Button buttonStatistics;
        private Button buttonUsers;
        private PictureBox pictureBox1;
        private Button buttonBack;
    }
}