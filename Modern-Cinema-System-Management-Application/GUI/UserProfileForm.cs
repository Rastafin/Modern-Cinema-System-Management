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
    public partial class UserProfileForm : Form
    {
        private readonly User _user;
        public UserProfileForm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void buttonWhatsOn_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            Close();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            buttonProfile.Enabled = false;
            buttonProfile.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _user!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _user!.Role);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin("");
            startFormLogin.Show();
            Close();
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            UserReservation userReservation = new UserReservation(_user!);
            userReservation.Show();
            Close();
        }
    }
}
