namespace GUI
{
    partial class AdminPanelMainMenu
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelMessage = new Label();
            buttonStatistics = new Button();
            buttonUsers = new Button();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            dataGridViewUsers = new DataGridView();
            textBoxFilter = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelMessage);
            panel1.Controls.Add(buttonStatistics);
            panel1.Controls.Add(buttonUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1215);
            panel1.TabIndex = 6;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.BackColor = Color.Coral;
            labelMessage.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Black;
            labelMessage.Location = new Point(5, 139);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(207, 40);
            labelMessage.TabIndex = 9;
            labelMessage.Text = "ADMIN PANEL";
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
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Coral;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUsers.ColumnHeadersHeight = 50;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.Snow;
            dataGridViewUsers.Location = new Point(332, 180);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Coral;
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.Coral;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GrayText;
            dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewUsers.RowTemplate.DefaultCellStyle.ForeColor = Color.Coral;
            dataGridViewUsers.RowTemplate.Height = 100;
            dataGridViewUsers.RowTemplate.ReadOnly = true;
            dataGridViewUsers.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1500, 950);
            dataGridViewUsers.TabIndex = 7;
            dataGridViewUsers.CellFormatting += dataGridViewUsers_CellFormatting;
            // 
            // textBoxFilter
            // 
            textBoxFilter.BackColor = Color.Coral;
            textBoxFilter.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFilter.Location = new Point(870, 62);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.PlaceholderText = "FILTER";
            textBoxFilter.Size = new Size(431, 46);
            textBoxFilter.TabIndex = 25;
            textBoxFilter.TextAlign = HorizontalAlignment.Center;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // AdminPanelMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1872, 1100);
            Controls.Add(textBoxFilter);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanelMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanelMainMenu";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanelMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonStatistics;
        private Button buttonUsers;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private DataGridView dataGridViewUsers;
        private Label labelMessage;
        private TextBox textBoxFilter;
    }
}