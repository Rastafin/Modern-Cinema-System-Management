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
    public partial class ConfirmationForm : Form
    {
        public bool WasYesClicked { get; private set; }

        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            WasYesClicked = true;
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            WasYesClicked = false;
            Close();
        }
    }
}
