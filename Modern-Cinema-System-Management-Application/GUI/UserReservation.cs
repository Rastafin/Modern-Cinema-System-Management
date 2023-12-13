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

        private void refreshData()
        {
            dataGridViewReservations.Rows.Clear();

            try
            {
                foreach (var reservation in Reservation.GetUserReseervations(_user.Id))
                {
                    DataGridViewRow? existingRow = dataGridViewReservations.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Title"].Value.ToString() == reservation.Title
                            && row.Cells["StartTime"].Value.ToString() == reservation.StartTime
                            && row.Cells["RoomNumber"].Value.ToString() == reservation.RoomNumber)
                            .FirstOrDefault();

                    if (existingRow == null)
                    {
                        var row = dataGridViewReservations.Rows[dataGridViewReservations.Rows.Add()];

                        row.Cells["Title"].Value = reservation.Title;
                        row.Cells["StartTime"].Value = reservation.StartTime;
                        row.Cells["RoomNumber"].Value = reservation.RoomNumber;
                        row.Cells["Seats"].Value = reservation.Seat;
                    }
                    else
                    {
                        existingRow.Cells["Seats"].Value += $", {reservation.Seat}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to get user reservations. " + ex.Message);
            }
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

            DataGridViewButtonColumn buttonColumnCancel = new DataGridViewButtonColumn();
            buttonColumnCancel.HeaderText = "Cancel Reservation";
            buttonColumnCancel.Text = "Cancel";
            buttonColumnCancel.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumnGenerateFile = new DataGridViewButtonColumn();
            buttonColumnGenerateFile.HeaderText = "Confirmation";
            buttonColumnGenerateFile.Text = "Generate";
            buttonColumnGenerateFile.UseColumnTextForButtonValue = true;

            dataGridViewReservations.Columns.Add(buttonColumnCancel);
            dataGridViewReservations.Columns.Add(buttonColumnGenerateFile);

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Padding = new Padding(50, 120, 50, 120);
            buttonColumnCancel.DefaultCellStyle = cellStyle;
            buttonColumnGenerateFile.DefaultCellStyle = cellStyle;

            refreshData();
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

        private void dataGridViewReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewReservations.Columns[e.ColumnIndex].Name == "Seats")
            {
                if (e.Value != null)
                {
                    dataGridViewReservations.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                }
            }
        }

        private void dataGridViewReservations_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewReservations.ClearSelection();
        }
    }
}
