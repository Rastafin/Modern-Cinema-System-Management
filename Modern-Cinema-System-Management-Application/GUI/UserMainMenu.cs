using Backend.Model;
using GUI.Functions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        //private readonly string _imagesPath = @"C:\ForkRepo\Modern-Cinema-System-Management\Modern-Cinema-System-Management-Application\Backend\Data\Pictures\";
        private readonly string _imagesPath = @"..\..\..\..\Backend\Data\Pictures\";
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
            StartFormLogin startFormLogin = new StartFormLogin("");
            startFormLogin.Show();
            this.Hide();
        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            buttonWhatsOn.Enabled = false;
            buttonWhatsOn.BackColor = Color.SlateGray;

            NavBarManager.SetAdminButtonVisibility(buttonAdminPanel, _user!.Role);
            NavBarManager.SetEmployeeButtonVisibility(buttonEmployeePanel, _user!.Role);

            try
            {
                var screenings = Screening.GetAllScreeningsWithRoomsAndMovies()
                    .Select(s => new
                    {
                        //ImagePath = Path.Combine(_imagesPath, s.Movie.ImageFileName!),
                        Image = Image.FromFile(_imagesPath + s.Movie.ImageFileName),
                        s.StartTime,
                        s.Movie.Title,
                        s.Movie.Description,
                        s.Movie.Director,
                        s.Movie.Duaration,
                    })
                    .ToList();

                dataGridViewMovies.AutoGenerateColumns = false;

                DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
                dataGridViewImageColumn.HeaderText = "";
                dataGridViewImageColumn.Name = "Image";
                dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewImageColumn.Width = 100;

                dataGridViewMovies.Columns.Add(dataGridViewImageColumn);

                dataGridViewMovies.Columns.Add("StartTime", "Start Time");
                dataGridViewMovies.Columns.Add("Title", "Title");
                dataGridViewMovies.Columns.Add("Description", "Description");
                dataGridViewMovies.Columns.Add("Director", "Director");
                dataGridViewMovies.Columns.Add("Duration", "Duration");


                foreach (var screening in screenings)
                {
                    if (screening.Image != null)
                    {
                        var row = dataGridViewMovies.Rows[dataGridViewMovies.Rows.Add()];

                        row.Cells["Image"].Value = screening.Image;
                        row.Cells["StartTime"].Value = screening.StartTime;
                        row.Cells["Title"].Value = screening.Title;
                        row.Cells["Description"].Value = screening.Description;
                        row.Cells["Director"].Value = screening.Director;
                        row.Cells["Duration"].Value = screening.Duaration;

                    }
                }

                foreach(DataGridViewColumn column in dataGridViewMovies.Columns)
                {
                    column.Resizable = DataGridViewTriState.False;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to load screenings" + ex.Message);
                return;
            }
        }

        private void dataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewMovies.ClearSelection();
        }
    }
}
