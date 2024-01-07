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
    public partial class EmployeePanelMainMenu : Form
    {
        private readonly User _user;
        public EmployeePanelMainMenu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void EmployeePanelMainMenu_Load(object sender, EventArgs e)
        {
            buttonUsersReservations.Enabled = false;
            buttonUsersReservations.BackColor = Color.SlateGray;

            dataGridViewReservations.AutoGenerateColumns = false;

            dataGridViewReservations.Columns.Add("ID", "ID");
            dataGridViewReservations.Columns.Add("Email", "Email");
            dataGridViewReservations.Columns.Add("Name", "Name");
            dataGridViewReservations.Columns.Add("Lastname", "Last name");
            dataGridViewReservations.Columns.Add("StartTime", "Start Time");
            dataGridViewReservations.Columns.Add("Title", "Title");
            dataGridViewReservations.Columns.Add("RoomNumber", "Room number");
            dataGridViewReservations.Columns.Add("Seats", "Seats");

            dataGridViewReservations.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewReservations.Columns["StartTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewReservations.Columns["Seats"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            loadReservationsToDGV();
        }

        private void loadReservationsToDGV(string filter = "")
        {
            dataGridViewReservations.Show();
            labelMessage.Text = String.Empty;

            try
            {
                List<Reservation> reservations = Reservation.GetNotDeletedReservations();

                if (reservations == null || reservations.Count == 0)
                {
                    dataGridViewReservations.Hide();
                    labelMessage.Text = "There are not any reservations";
                    return;
                }

                dataGridViewReservations.Rows.Clear();

                foreach (Reservation reservation in reservations)
                {
                    Client client = Client.GetClient((int)reservation.UserId);

                    if (string.IsNullOrEmpty(filter)
                        || (reservation.Id.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.Name != null && client.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (client.LastName != null && client.LastName.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {


                        DataGridViewRow? existingRow = dataGridViewReservations.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Title"].Value.ToString() == reservation.Screening!.Movie.Title
                            && row.Cells["StartTime"].Value.ToString() == reservation.Screening.StartTime
                            && row.Cells["Email"].Value.ToString() == client.User.Email
                            && row.Cells["RoomNumber"].Value.ToString() == reservation.Screening.Room.RoomNumber)
                            .FirstOrDefault();

                        if (existingRow == null)
                        {
                            var row = dataGridViewReservations.Rows[dataGridViewReservations.Rows.Add()];

                            row.Cells["ID"].Value = reservation.Id;
                            row.Cells["Email"].Value = client.User.Email;
                            row.Cells["Name"].Value = client.Name;
                            row.Cells["Lastname"].Value = client.LastName;
                            row.Cells["StartTime"].Value = reservation.Screening!.StartTime;
                            row.Cells["Title"].Value = reservation.Screening.Movie.Title;
                            row.Cells["RoomNumber"].Value = reservation.Screening.Room.RoomNumber;
                            row.Cells["Seats"].Value = reservation.Seat;
                        }
                        else
                        {
                            existingRow.Cells["Seats"].Value += $", {reservation.Seat}";
                        }

                    }
                }

                if (dataGridViewReservations.Rows.Count < 1)
                {
                    labelMessage.Text = "Cannot find any reservation";
                    dataGridViewReservations.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load reservations. " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadReservationsToDGV(filter);
        }
    }
}
