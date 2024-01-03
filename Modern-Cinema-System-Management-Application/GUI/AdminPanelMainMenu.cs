﻿using Backend.Model;
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
    public partial class AdminPanelMainMenu : Form
    {
        private readonly User _user;
        public AdminPanelMainMenu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminPanelMainMenu_Load(object sender, EventArgs e)
        {
            buttonUsers.Enabled = false;
            buttonUsers.BackColor = Color.SlateGray;

            dataGridViewUsers.AutoGenerateColumns = false;

            dataGridViewUsers.Columns.Add("Name", "Name");
            dataGridViewUsers.Columns.Add("Lastname", "Last name");
            dataGridViewUsers.Columns.Add("Birthday", "Birthday");
            dataGridViewUsers.Columns.Add("Sex", "Sex");
            dataGridViewUsers.Columns.Add("PhoneNumber", "Phone number");
            dataGridViewUsers.Columns.Add("Login", "Login");
            dataGridViewUsers.Columns.Add("Email", "Email");
            dataGridViewUsers.Columns.Add("Role", "Role");
            dataGridViewUsers.Columns.Add("Status", "Status");

            //dataGridViewUsers.Columns.Add("Country", "Country");
            //dataGridViewUsers.Columns.Add("City", "City");
            //dataGridViewUsers.Columns.Add("Street", "Street");
            //dataGridViewUsers.Columns.Add("HouseNumber", "House number");
            //dataGridViewUsers.Columns.Add("Zip code", "ZipCode");

            dataGridViewUsers.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewUsers.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewUsers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            loadUsersToDGV();
        }

        private void loadUsersToDGV(string filter = "")
        {
            try
            {
                List<Client> clients = Client.GetClients();

                if (clients == null || clients.Count == 0)
                {
                    dataGridViewUsers.Hide();
                    //labelMessage.Text = "There are not any users";
                    return;
                }

                dataGridViewUsers.Rows.Clear();

                foreach (Client client in clients)
                {
                    if(string.IsNullOrEmpty(filter)
                        || (client.Name != null && client.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.LastName != null && client.LastName.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.User.Login != null && client.User.Login.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.User.Email != null && client.User.Email.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {
                        var row = dataGridViewUsers.Rows[dataGridViewUsers.Rows.Add()];

                        row.Cells["Name"].Value = client.Name;
                        row.Cells["LastName"].Value = client.LastName;
                        row.Cells["Birthday"].Value = client.Birthday;
                        row.Cells["Sex"].Value = client.Sex;
                        row.Cells["PhoneNumber"].Value = client.PhoneNumber;
                        row.Cells["Login"].Value = client.User.Login;
                        row.Cells["Email"].Value = client.User.Email;
                        row.Cells["Role"].Value = client.User.Role;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to load users. " + ex.Message);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 1)
            {
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadUsersToDGV(filter);
        }
    }
}
