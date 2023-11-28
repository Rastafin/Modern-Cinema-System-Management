namespace GUI
{
    partial class UserMainMenu
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
            buttonAdminPanel = new Button();
            buttonEmployeePanel = new Button();
            buttonReservations = new Button();
            buttonComingSoon = new Button();
            buttonWhatsOn = new Button();
            buttonProfile = new Button();
            pictureBox1 = new PictureBox();
            buttonLogout = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(buttonAdminPanel);
            panel1.Controls.Add(buttonEmployeePanel);
            panel1.Controls.Add(buttonReservations);
            panel1.Controls.Add(buttonComingSoon);
            panel1.Controls.Add(buttonWhatsOn);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogout);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 5;
            // 
            // buttonAdminPanel
            // 
            buttonAdminPanel.BackColor = Color.Coral;
            buttonAdminPanel.FlatAppearance.BorderColor = Color.Black;
            buttonAdminPanel.FlatAppearance.BorderSize = 2;
            buttonAdminPanel.FlatStyle = FlatStyle.Flat;
            buttonAdminPanel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdminPanel.Location = new Point(12, 612);
            buttonAdminPanel.Name = "buttonAdminPanel";
            buttonAdminPanel.Size = new Size(200, 77);
            buttonAdminPanel.TabIndex = 13;
            buttonAdminPanel.Text = "ADMIN PANEL";
            buttonAdminPanel.UseVisualStyleBackColor = false;
            // 
            // buttonEmployeePanel
            // 
            buttonEmployeePanel.BackColor = Color.Coral;
            buttonEmployeePanel.FlatAppearance.BorderColor = Color.Black;
            buttonEmployeePanel.FlatAppearance.BorderSize = 2;
            buttonEmployeePanel.FlatStyle = FlatStyle.Flat;
            buttonEmployeePanel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEmployeePanel.Location = new Point(12, 500);
            buttonEmployeePanel.Name = "buttonEmployeePanel";
            buttonEmployeePanel.Size = new Size(200, 86);
            buttonEmployeePanel.TabIndex = 12;
            buttonEmployeePanel.Text = "EMPLOYEE PANEL";
            buttonEmployeePanel.UseVisualStyleBackColor = false;
            // 
            // buttonReservations
            // 
            buttonReservations.BackColor = Color.Coral;
            buttonReservations.FlatAppearance.BorderColor = Color.Black;
            buttonReservations.FlatAppearance.BorderSize = 2;
            buttonReservations.FlatStyle = FlatStyle.Flat;
            buttonReservations.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonReservations.Location = new Point(12, 409);
            buttonReservations.Name = "buttonReservations";
            buttonReservations.Size = new Size(200, 56);
            buttonReservations.TabIndex = 11;
            buttonReservations.Text = "RESERVATIONS";
            buttonReservations.UseVisualStyleBackColor = false;
            // 
            // buttonComingSoon
            // 
            buttonComingSoon.BackColor = Color.Coral;
            buttonComingSoon.FlatAppearance.BorderColor = Color.Black;
            buttonComingSoon.FlatAppearance.BorderSize = 2;
            buttonComingSoon.FlatStyle = FlatStyle.Flat;
            buttonComingSoon.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonComingSoon.Location = new Point(12, 319);
            buttonComingSoon.Name = "buttonComingSoon";
            buttonComingSoon.Size = new Size(200, 56);
            buttonComingSoon.TabIndex = 10;
            buttonComingSoon.Text = "COMING SOON";
            buttonComingSoon.UseVisualStyleBackColor = false;
            // 
            // buttonWhatsOn
            // 
            buttonWhatsOn.BackColor = Color.Coral;
            buttonWhatsOn.FlatAppearance.BorderColor = Color.Black;
            buttonWhatsOn.FlatAppearance.BorderSize = 2;
            buttonWhatsOn.FlatStyle = FlatStyle.Flat;
            buttonWhatsOn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonWhatsOn.Location = new Point(12, 227);
            buttonWhatsOn.Name = "buttonWhatsOn";
            buttonWhatsOn.Size = new Size(200, 56);
            buttonWhatsOn.TabIndex = 9;
            buttonWhatsOn.Text = "WHAT'S ON";
            buttonWhatsOn.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Coral;
            buttonProfile.FlatAppearance.BorderColor = Color.Black;
            buttonProfile.FlatAppearance.BorderSize = 2;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonProfile.Location = new Point(12, 955);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(200, 56);
            buttonProfile.TabIndex = 8;
            buttonProfile.Text = "YOUR PROFILE";
            buttonProfile.UseVisualStyleBackColor = false;
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
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Coral;
            buttonLogout.FlatAppearance.BorderColor = Color.Black;
            buttonLogout.FlatAppearance.BorderSize = 2;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogout.Location = new Point(12, 1044);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(200, 56);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(332, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1455, 873);
            dataGridView1.TabIndex = 6;
            // 
            // UserMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1872, 1220);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainMenu";
            WindowState = FormWindowState.Maximized;
            Load += UserMainMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Button buttonProfile;
        private Button buttonWhatsOn;
        private Button buttonReservations;
        private Button buttonComingSoon;
        private Button buttonAdminPanel;
        private Button buttonEmployeePanel;
        private DataGridView dataGridView1;
    }
}