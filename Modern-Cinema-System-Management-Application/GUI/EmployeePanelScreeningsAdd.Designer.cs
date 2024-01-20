namespace GUI
{
    partial class EmployeePanelScreeningsAdd
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
            buttonCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            labelMovieDetails = new Label();
            comboBoxSex = new ComboBox();
            textBoxMovie = new TextBox();
            buttonAddScreening = new Button();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSalmon;
            buttonCancel.FlatAppearance.BorderColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCancel.Location = new Point(524, 546);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(157, 46);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.Black;
            dateTimePicker1.CalendarTitleBackColor = Color.Black;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.White;
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(162, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 43);
            dateTimePicker1.TabIndex = 33;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(433, 221);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 43);
            maskedTextBox1.TabIndex = 34;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // labelMovieDetails
            // 
            labelMovieDetails.AutoSize = true;
            labelMovieDetails.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelMovieDetails.ForeColor = Color.Coral;
            labelMovieDetails.Location = new Point(162, 60);
            labelMovieDetails.Name = "labelMovieDetails";
            labelMovieDetails.Size = new Size(379, 51);
            labelMovieDetails.TabIndex = 63;
            labelMovieDetails.Text = "SCREENING DETAILS";
            labelMovieDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSex
            // 
            comboBoxSex.BackColor = Color.LightSalmon;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FlatStyle = FlatStyle.Flat;
            comboBoxSex.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(162, 346);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(371, 48);
            comboBoxSex.TabIndex = 65;
            // 
            // textBoxMovie
            // 
            textBoxMovie.BackColor = Color.Coral;
            textBoxMovie.Enabled = false;
            textBoxMovie.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMovie.Location = new Point(162, 303);
            textBoxMovie.Name = "textBoxMovie";
            textBoxMovie.PlaceholderText = "MOVIE";
            textBoxMovie.Size = new Size(371, 46);
            textBoxMovie.TabIndex = 64;
            textBoxMovie.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddScreening
            // 
            buttonAddScreening.BackColor = Color.Coral;
            buttonAddScreening.FlatAppearance.BorderColor = Color.Black;
            buttonAddScreening.FlatAppearance.BorderSize = 2;
            buttonAddScreening.FlatStyle = FlatStyle.Flat;
            buttonAddScreening.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddScreening.Location = new Point(259, 454);
            buttonAddScreening.Name = "buttonAddScreening";
            buttonAddScreening.Size = new Size(200, 77);
            buttonAddScreening.TabIndex = 66;
            buttonAddScreening.Text = "Add";
            buttonAddScreening.UseVisualStyleBackColor = false;
            // 
            // EmployeePanelScreeningsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(714, 623);
            Controls.Add(buttonAddScreening);
            Controls.Add(comboBoxSex);
            Controls.Add(textBoxMovie);
            Controls.Add(labelMovieDetails);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeePanelScreeningsAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePanelScreeningsAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label labelMovieDetails;
        private ComboBox comboBoxSex;
        private TextBox textBoxMovie;
        private Button buttonAddScreening;
    }
}