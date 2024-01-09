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
    public partial class EmployeePanelMovies : Form
    {
        private readonly User _user;
        private Movie _newMovie;
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
                        string selectedImagePath = openFileDialogMoviePictureFile.FileName;
                        _newMovie.ImageFileName = Path.GetFileName(selectedImagePath);

                        pictureBoxMoviePicture.Image = Image.FromFile(selectedImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to add new movie. " + ex.Message);
            }
        }
    }
}
