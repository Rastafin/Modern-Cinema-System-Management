namespace GUI
{
    partial class RegisterForm
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
            buttonBack = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxLastname = new TextBox();
            textBoxBirthday = new TextBox();
            textBoxSex = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            textBoxHouseNumber = new TextBox();
            textBoxZipCode = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 114);
            panel1.TabIndex = 5;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Coral;
            buttonBack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.Location = new Point(927, 893);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(200, 56);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.Coral;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(220, 263);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "LOGIN";
            textBoxLogin.Size = new Size(431, 46);
            textBoxLogin.TabIndex = 7;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.Coral;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(220, 361);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "PASSWORD";
            textBoxPassword.Size = new Size(431, 46);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.Coral;
            textBoxEmail.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(220, 445);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "EMAIL";
            textBoxEmail.Size = new Size(431, 46);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Coral;
            textBoxName.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(808, 263);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "NAME";
            textBoxName.Size = new Size(431, 46);
            textBoxName.TabIndex = 10;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLastname
            // 
            textBoxLastname.BackColor = Color.Coral;
            textBoxLastname.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastname.Location = new Point(808, 361);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.PlaceholderText = "LASTNAME";
            textBoxLastname.Size = new Size(431, 46);
            textBoxLastname.TabIndex = 11;
            textBoxLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBirthday
            // 
            textBoxBirthday.BackColor = Color.Coral;
            textBoxBirthday.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxBirthday.Location = new Point(808, 459);
            textBoxBirthday.Name = "textBoxBirthday";
            textBoxBirthday.PlaceholderText = "BIRTHDAY";
            textBoxBirthday.Size = new Size(431, 46);
            textBoxBirthday.TabIndex = 12;
            textBoxBirthday.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSex
            // 
            textBoxSex.BackColor = Color.Coral;
            textBoxSex.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSex.Location = new Point(808, 563);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.PlaceholderText = "SEX";
            textBoxSex.Size = new Size(431, 46);
            textBoxSex.TabIndex = 13;
            textBoxSex.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.Coral;
            textBoxPhoneNumber.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(808, 657);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "PHONE NUMBER";
            textBoxPhoneNumber.Size = new Size(431, 46);
            textBoxPhoneNumber.TabIndex = 14;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCountry
            // 
            textBoxCountry.BackColor = Color.Coral;
            textBoxCountry.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCountry.Location = new Point(1334, 263);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PlaceholderText = "COUNTRY";
            textBoxCountry.Size = new Size(431, 46);
            textBoxCountry.TabIndex = 11;
            textBoxCountry.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCity
            // 
            textBoxCity.BackColor = Color.Coral;
            textBoxCity.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCity.Location = new Point(1334, 361);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "CITY";
            textBoxCity.Size = new Size(431, 46);
            textBoxCity.TabIndex = 15;
            textBoxCity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStreet
            // 
            textBoxStreet.BackColor = Color.Coral;
            textBoxStreet.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxStreet.Location = new Point(1334, 459);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.PlaceholderText = "STREET";
            textBoxStreet.Size = new Size(431, 46);
            textBoxStreet.TabIndex = 16;
            textBoxStreet.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxHouseNumber
            // 
            textBoxHouseNumber.BackColor = Color.Coral;
            textBoxHouseNumber.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxHouseNumber.Location = new Point(1334, 563);
            textBoxHouseNumber.Name = "textBoxHouseNumber";
            textBoxHouseNumber.PlaceholderText = "HOUSE NUMBER";
            textBoxHouseNumber.Size = new Size(431, 46);
            textBoxHouseNumber.TabIndex = 17;
            textBoxHouseNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.BackColor = Color.Coral;
            textBoxZipCode.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxZipCode.Location = new Point(1334, 657);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.PlaceholderText = "ZIP CODE";
            textBoxZipCode.Size = new Size(431, 46);
            textBoxZipCode.TabIndex = 18;
            textBoxZipCode.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Coral;
            buttonRegister.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegister.Location = new Point(927, 797);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(200, 56);
            buttonRegister.TabIndex = 19;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1888, 1002);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxZipCode);
            Controls.Add(textBoxHouseNumber);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxSex);
            Controls.Add(textBoxBirthday);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            WindowState = FormWindowState.Maximized;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxLastname;
        private TextBox textBoxBirthday;
        private TextBox textBoxSex;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxHouseNumber;
        private TextBox textBoxZipCode;
        private Button buttonRegister;
    }
}