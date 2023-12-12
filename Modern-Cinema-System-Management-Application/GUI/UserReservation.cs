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
    public partial class UserReservation : Form
    {
        private readonly User _user;
        public UserReservation(User user)
        {
            _user = user;

            InitializeComponent();
        }

        private void UserReservation_Load(object sender, EventArgs e)
        {
            buttonReservations.Enabled = false;
            buttonReservations.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _user!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _user!.Role);

            dataGridViewReservations.AutoGenerateColumns = false;

            dataGridViewReservations.Columns.Add("Title", "Title");
            dataGridViewReservations.Columns.Add("StartTime", "Start Time");
            dataGridViewReservations.Columns.Add("RoomNumber", "Room Number");
            dataGridViewReservations.Columns.Add("Seats", "Seats");
        }

        private void buttonWhatsOn_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            StartFormLogin startFormLogin = new StartFormLogin("");
            startFormLogin.Show();
            Close();
        }
    }
}
