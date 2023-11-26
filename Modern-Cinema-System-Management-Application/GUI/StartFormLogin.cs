using Backend.Data;
using Backend.Model;

namespace GUI
{
    public partial class StartFormLogin : Form
    {
        public StartFormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            try
            {
                if (User.ValidateUser(login, password, out int userId))
                {
                    UserMainMenu userMainMenu = new UserMainMenu(userId);
                    userMainMenu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to log in you");
            }
        }
    }
}