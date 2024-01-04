using Backend.Model;
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
    public partial class AdminPanelStatistics : Form
    {
        private readonly User _user;
        public AdminPanelStatistics(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e)
        {
            buttonStatistics.Enabled = false;
            buttonStatistics.BackColor = Color.SlateGray;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AdminPanelMainMenu? adminPanelMainMenu = Application.OpenForms.OfType<AdminPanelMainMenu>().FirstOrDefault();

            if (adminPanelMainMenu != null) { adminPanelMainMenu.Show(); }

            this.Close();
        }
    }
}
