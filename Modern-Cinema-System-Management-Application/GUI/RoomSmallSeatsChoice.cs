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
                    return !_buttonStatusList[i];
                }
            }
            return false;
        }

        public RoomSmallSeatsChoice()
        {
            InitializeComponent();
            listOfButtonsInitialization();
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
            /*if (buttonClicked(button1.Text))
            {
                button1.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Green;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void buttonChooseBook_Click(object sender, EventArgs e)
        {

        }
    }
}
