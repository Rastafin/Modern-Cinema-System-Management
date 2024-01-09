using Backend.Model;
using Backend.Model.Enums;
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
    public partial class EmployeePanelMovies : Form
    {
        private readonly User _user;
        private Movie _newMovie;
        private string _selectedImagePath;
        private readonly string _imagesPath = @"..\..\..\..\Backend\Data\Pictures\";
        public EmployeePanelMovies(User user)
        {
            InitializeComponent();
            _user = user;
            _newMovie = new Movie();
        }

        private void EmployeePanelMovies_Load(object sender, EventArgs e)
        {
            buttonAddMovieForm.Enabled = false;
            buttonAddMovieForm.BackColor = Color.SlateGray;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialogMoviePictureFile = new OpenFileDialog())
                {
                    openFileDialogMoviePictureFile.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                    if (openFileDialogMoviePictureFile.ShowDialog() == DialogResult.OK)
                    {
                        _selectedImagePath = openFileDialogMoviePictureFile.FileName;

                        _newMovie.ImageFileName = Path.GetFileName(_selectedImagePath);

                        pictureBoxMoviePicture.Image = Image.FromFile(_selectedImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new movie picture. " + ex.Message);
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                MovieCategory parsedMovieCategory;

                if (!Enum.TryParse(comboBoxCategory.Text, out parsedMovieCategory))  // need to make some change and put it to validationService
                {
                    //labelMessage.Text = "Bad Sex format";
                    return;
                }

                if (!string.IsNullOrEmpty(_newMovie.ImageFileName) && !string.IsNullOrEmpty(_selectedImagePath))
                {
                    string targetImagePath = Path.Combine(_imagesPath, _newMovie.ImageFileName);
                    File.Copy(_selectedImagePath, targetImagePath);
                }
                else
                {
                    throw new Exception("Error occurred while uploading photo");
                }

                _newMovie.Title = textBoxTitle.Text;
                _newMovie.Description = textBoxDescription.Text;
                _newMovie.Duaration = int.Parse(textBoxDuration.Text);
                _newMovie.Director = textBoxDirector.Text;
                _newMovie.ReleaseDate = dateTimePickerReleaseDate.Text;
                _newMovie.WithdrawalDate = dateTimePickerWithdrawalDate.Text;
                _newMovie.Category = parsedMovieCategory;

                Movie.AddNewMovie(_newMovie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new movie. " + ex.Message);
            }
        }

        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
