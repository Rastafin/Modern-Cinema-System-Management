using Backend.Model;
using Backend.Model.Enums;
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

            if (!Enum.TryParse(textBoxSex.Text, out parsedSex))
            {
                MessageBox.Show("Bad Sex format");
                return;
            }

            Client client = new Client(textBoxName.Text, textBoxLastname.Text, textBoxBirthday.Text, parsedSex, textBoxPhoneNumber.Text,
                textBoxCountry.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNumber.Text, textBoxZipCode.Text);

            User user = new User(textBoxLogin.Text, textBoxPassword.Text, textBoxEmail.Text);

            try
            {
                client.Register(client, user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to register your account");
            }
        }
    }
}
