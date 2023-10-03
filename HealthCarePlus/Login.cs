namespace HealthCarePlus
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";

            string usernamerecep = "recep";
            string receppassword = "recep";

            string enteredUsername = UsernameBox.Text;
            string enteredPassword = PasswordBox.Text;

            if (enteredUsername == username && enteredPassword == password)
            {
                Menu menuForm = new Menu();
                menuForm.Show();
                this.Hide(); 
            }
            else if(enteredUsername == usernamerecep && enteredPassword == receppassword)
            {
                
                ReceptionistMenu ReceptionistmenuForm = new ReceptionistMenu();
                ReceptionistmenuForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Welcome(object sender, EventArgs e)
        {

        }
    }
}