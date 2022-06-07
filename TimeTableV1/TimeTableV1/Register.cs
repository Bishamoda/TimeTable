using TimeTableV1.Data;
using TimeTableV1.Models;
using TimeTableV1.Repositories;

namespace TimeTableV1
{
    public partial class Register : Form
    {
        private IUsersRepository? _usersRepository;

        public Register()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            _usersRepository = new UsersRepository(new DBContext());
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Failed to add the user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                user.Name = textBoxName.Text;
                user.Password = textBoxPassword.Text;
                if (user != null)
                {
                    _usersRepository.CreateUser(user);
                    MessageBox.Show("User created", "Correct",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
