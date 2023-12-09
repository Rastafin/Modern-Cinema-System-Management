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
    public partial class RoomSmallSeatsChoice : Form
    {
        private List<bool> _buttonStatusList = new List<bool>();
        private readonly int _screeningId;
        private readonly User _user;
        private void listOfButtonsInitialization()
        {
            for (int i = 0; i < 20; i++)
            {
                _buttonStatusList.Add(false);
            }
        }

        private bool buttonClicked(string buttonText)
        {
            int idButtonInList = int.Parse(buttonText) - 1;

            for (int i = 0; i < 20; i++)
            {
                if (i == idButtonInList)
                {
                    _buttonStatusList[i] = !_buttonStatusList[i];
                    return _buttonStatusList[i];
                }
            }
            return false;
        }

        public RoomSmallSeatsChoice(int screeningId, User user)
        {
            InitializeComponent();
            listOfButtonsInitialization();
            _screeningId = screeningId;
            _user = user;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomSmallSeatsChoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button1.Text))
            {
                button1.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button2.Text))
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button2.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button3.Text))
            {
                button3.BackColor = Color.Blue;
            }
            else
            {
                button3.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button4.Text))
            {
                button4.BackColor = Color.Blue;
            }
            else
            {
                button4.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button5.Text))
            {
                button5.BackColor = Color.Blue;
            }
            else
            {
                button5.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button6.Text))
            {
                button6.BackColor = Color.Blue;
            }
            else
            {
                button6.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button7.Text))
            {
                button7.BackColor = Color.Blue;
            }
            else
            {
                button7.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button8.Text))
            {
                button8.BackColor = Color.Blue;
            }
            else
            {
                button8.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button9.Text))
            {
                button9.BackColor = Color.Blue;
            }
            else
            {
                button9.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button10.Text))
            {
                button10.BackColor = Color.Blue;
            }
            else
            {
                button10.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button11.Text))
            {
                button11.BackColor = Color.Blue;
            }
            else
            {
                button11.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button12.Text))
            {
                button12.BackColor = Color.Blue;
            }
            else
            {
                button12.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button13.Text))
            {
                button13.BackColor = Color.Blue;
            }
            else
            {
                button13.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button14.Text))
            {
                button14.BackColor = Color.Blue;
            }
            else
            {
                button14.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button15.Text))
            {
                button15.BackColor = Color.Blue;
            }
            else
            {
                button15.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button16.Text))
            {
                button16.BackColor = Color.Blue;
            }
            else
            {
                button16.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button17.Text))
            {
                button17.BackColor = Color.Blue;
            }
            else
            {
                button17.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button18.Text))
            {
                button18.BackColor = Color.Blue;
            }
            else
            {
                button18.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button19.Text))
            {
                button19.BackColor = Color.Blue;
            }
            else
            {
                button19.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (buttonClicked(button20.Text))
            {
                button20.BackColor = Color.Blue;
            }
            else
            {
                button20.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void buttonChooseBook_Click(object sender, EventArgs e)
        {

        }
    }
}
