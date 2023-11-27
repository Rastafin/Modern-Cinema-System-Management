using Backend.Model;
using Backend.Model.Enums;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin();
            startFormLogin.Show();
            this.Hide();
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            Sex parsedSex;

            if (!ValidationService.ValidateClientRegisterProcess(textBoxName.Text, textBoxLastname.Text, textBoxBirthday.Text, textBoxPhoneNumber.Text,
                textBoxCountry.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNumber.Text, maskedTextBoxZipCode.Text, out string message))
            {
                labelMessage.Text = message;
                return;
            }

            if(!ValidationService.ValidateUserRegisterProcess(textBoxLogin.Text, textBoxPassword.Text, textBoxEmail.Text, out string secondMessage))
            {
                labelMessage.Text = secondMessage;
                return;
            }

            if (!Enum.TryParse(textBoxSex.Text, out parsedSex))  // need to make some change and put it to validationService
            {
                labelMessage.Text = "Bad Sex format";
                return;
            }

            try
            {
                Client.AddClientWithUser(new Client(textBoxName.Text, textBoxLastname.Text, textBoxBirthday.Text, parsedSex, textBoxPhoneNumber.Text,
                textBoxCountry.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNumber.Text, maskedTextBoxZipCode.Text),
                    new User(textBoxLogin.Text, PasswordHasher.HashPassword(textBoxPassword.Text), textBoxEmail.Text));
            }
            catch (Exception ex)
            {
                labelMessage.Text = "Error occured while trying to register your account";
            }
        }
    }
}
