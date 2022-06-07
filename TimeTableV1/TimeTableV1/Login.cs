using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableV1.Data;
using TimeTableV1.Models;
using TimeTableV1.Repositories;

namespace TimeTableV1
{
    public partial class Login : Form
    {
        private IUsersRepository? _usersRepository;
        public Login()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            _usersRepository = new UsersRepository(new DBContext());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Failed to login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _usersRepository.GetAllUsers().Where(u => u.Name == textBoxName.Text && u.Password == textBoxPassword.Text);

                CreateMainForm(textBoxName.Text);
            }
        }

        private void CreateMainForm(string name)
        {
            TimeTable timeTable = new TimeTable(name);
            timeTable.Show();
            this.Hide();
            if (timeTable.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            if (register.DialogResult == DialogResult.Cancel)
                register.Close();
            
            this.Show();
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
    }
}
