﻿using Backend.Model;
using Backend.Services;
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

            //dataGridViewMovies.Columns["StartTime"].Width = 300;

            loadScreeningsByDate();
        }

        private void loadScreeningsByDate()
        {
            try
            {
                string selectedDateFromPicker = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var screenings = Screening.GetAllScreeningsWithRoomsAndMovies()
                    .Select(s => new
                    {
                        Image = Image.FromFile(_imagesPath + s.Movie.ImageFileName),
                        s.StartTime,
                        s.Movie.Title,
                        s.Movie.Description,
                        s.Movie.Director,
                        s.Movie.Duaration,
                    }).Where(n => ParsingService.ParseStartDate(n.StartTime) == selectedDateFromPicker)
                    .ToList();

                dataGridViewMovies.Rows.Clear();

                dataGridViewMovies.Show();
                labelMessage.Text = String.Empty;

                if (screenings == null || screenings.Count == 0)
                {
                    dataGridViewMovies.Hide();
                    labelMessage.Text = "There are not any movies on the selected date";
                    return;
                }

                foreach (var screening in screenings)
                {
                    if (screening.Image != null)
                    {

                        DataGridViewRow? existingRow = dataGridViewMovies.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Title"].Value.ToString() == screening.Title)
                            .FirstOrDefault();

                        if (existingRow == null)
                        {
                            var row = dataGridViewMovies.Rows[dataGridViewMovies.Rows.Add()];

                            row.Cells["Image"].Value = screening.Image;
                            row.Cells["StartTime"].Value = ParsingService.ParseStartTime(screening.StartTime);
                            row.Cells["Title"].Value = screening.Title;
                            row.Cells["Description"].Value = screening.Description;
                            row.Cells["Director"].Value = screening.Director;
                            row.Cells["Duration"].Value = screening.Duaration;
                        }
                        else
                        {
                            existingRow.Cells["StartTime"].Value += $", {ParsingService.ParseStartTime(screening.StartTime)}";
                        }

                    }
                }

                foreach (DataGridViewColumn column in dataGridViewMovies.Columns)
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

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadScreeningsByDate();
        }

        private void dataGridViewMovies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewMovies.Columns[e.ColumnIndex].Name == "StartTime")
            {
                if (e.Value != null)
                {
                    dataGridViewMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                }
            }
        }
    }
}
