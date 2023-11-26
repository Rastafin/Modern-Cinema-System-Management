using Backend.Model;
using GUI.Functions;
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
    public partial class UserMainMenu : Form
    {
        private readonly User? _user;
        public UserMainMenu(int userId)
        {
            InitializeComponent();

            try
            {
                _user = User.GetUserByUserId(userId);
                if (_user == null)
                {
                    MessageBox.Show("User is null. Try again");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error occured in UserMainMenu after trying to log you in");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin();
            startFormLogin.Show();
            this.Hide();
        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            buttonWhatsOn.Enabled = false;
            buttonWhatsOn.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _user!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _user!.Role);

            //MessageBox.Show(_user.Login.ToString());
        }
    }
}
