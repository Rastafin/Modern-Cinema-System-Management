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
    public partial class UserTicketsAmountChoice : Form
    {
        private readonly Movie _movie;
        private readonly string _movieDate;
        private readonly string _imagesPath;
        private readonly User _user;
        public UserTicketsAmountChoice(Movie movie, string movieDate, string imagesPath, User user)
        {
            _movie = movie;
            _movieDate = movieDate;
            _imagesPath = imagesPath;
            _user = user;

            InitializeComponent();
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserTicketsAmountChoice_Load(object sender, EventArgs e)
        {
            labelMovieTitle.Text = _movie.Title;
            labelDate.Text = _movieDate;

            string imagePath = _imagesPath + _movie.ImageFileName;

            if (File.Exists(imagePath))
            {
                pictureBoxMovie.ImageLocation = imagePath;
            }
            try
            {
                comboBoxMovieHours.Items.AddRange(Screening.GetMovieHoursOnSelectedDate(_movie.Id, _movieDate).ToArray());
                comboBoxMovieHours.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to get movie hours. " + ex.Message);
            }
        }

        private void buttonChooseSeats_Click(object sender, EventArgs e)
        {
            if(!(numericUpDownHalfprice.Value > 0 || numericUpDownRegular.Value >0))
            {
                labelMessage.Visible = true;
                return;
            }

            try
            {
                string dateWithHour = _movieDate + " " + comboBoxMovieHours.SelectedItem.ToString();
                
                if(Screening.GetRoomIdOnSelectedDate(dateWithHour, _movie.Id) == 1)
                {
                    //MessageBox.Show(Screening.GetScreeningIdFromDateAndMovie(dateWithHour, _movie.Id).ToString());    
                    labelMessage.Visible = false;
                    RoomSmallSeatsChoice roomSmallSeatsChoice 
                        = new RoomSmallSeatsChoice(Screening.GetScreeningIdFromDateAndMovie(dateWithHour, _movie.Id), _user);

                    roomSmallSeatsChoice.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured while trying load RoomSeatsChoice Interface" + ex.Message);
            }
        }
    }
}
