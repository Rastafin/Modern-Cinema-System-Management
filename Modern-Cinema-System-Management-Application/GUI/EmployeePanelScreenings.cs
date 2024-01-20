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
    public partial class EmployeePanelScreenings : Form
    {
        private readonly User _user;
        public EmployeePanelScreenings(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void EmployeePanelScreenings_Load(object sender, EventArgs e)
        {
            buttonScreenings.Enabled = false;
            buttonScreenings.BackColor = Color.SlateGray;

            dataGridViewScreenings.AutoGenerateColumns = false;

            dataGridViewScreenings.Columns.Add("StartTime", "Start Time");
            dataGridViewScreenings.Columns.Add("Title", "Title");
            dataGridViewScreenings.Columns.Add("RoomNumber", "Room number");
            dataGridViewScreenings.Columns.Add("NumberOfReservedSeats", "Number of reserved seats");

            loadScreeningsToDGV();
        }

        private void loadScreeningsToDGV(string filter = "")
        {
            dataGridViewScreenings.Show();
            labelMessage.Text = String.Empty;

            try
            {
                List<Screening> screenings = Screening.GetCurrentScreenings();

                if (screenings == null || screenings.Count == 0)
                {
                    dataGridViewScreenings.Hide();
                    labelMessage.Text = "There are not any screenings";
                    return;
                }

                dataGridViewScreenings.Rows.Clear();

                foreach (Screening screening in screenings)
                {
                    if (string.IsNullOrEmpty(filter)
                        || (screening.StartTime != null && screening.StartTime.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (screening.Movie.Title != null && screening.Movie.Title.Contains(filter, StringComparison.OrdinalIgnoreCase))
                        || (screening.Room.RoomNumber != null && screening.Room.RoomNumber.Contains(filter, StringComparison.OrdinalIgnoreCase)))
                    {
                        var row = dataGridViewScreenings.Rows[dataGridViewScreenings.Rows.Add()];

                        row.Cells["StartTime"].Value = screening.StartTime;
                        row.Cells["Title"].Value = screening.Movie.Title;
                        row.Cells["RoomNumber"].Value = screening.Room.RoomNumber;
                        row.Cells["NumberOfReservedSeats"].Value = Reservation.GetNumberOfReservedSeatsForScreening(screening.Id);
                    }
                }

                if (dataGridViewScreenings.Rows.Count < 1)
                {
                    labelMessage.Text = "Cannot find any reservation";
                    dataGridViewScreenings.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load screenings. " + ex.Message);
            }
        }

        private void buttonUsersReservations_Click(object sender, EventArgs e)
        {
            EmployeePanelMainMenu employeePanelMainMenu = new EmployeePanelMainMenu(_user);
            employeePanelMainMenu.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>()
                            .Where(r => r.GetLoggedInUser().Id == _user.Id)
                            .FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonAddMovieForm_Click(object sender, EventArgs e)
        {
            EmployeePanelMovies employeePanelMovies = new EmployeePanelMovies(_user);
            employeePanelMovies.Show();
            this.Close();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.Trim();
            loadScreeningsToDGV(filter);
        }
    }
}
