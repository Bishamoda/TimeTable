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
using TimeTableV1.Services;

namespace TimeTableV1
{
    public partial class Login : Form
    {
        private readonly IUsersService _usersService;
        public Login(IUsersService usersService)
        {
            InitializeComponent();
            _usersService = usersService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = textBox1.Text;
            user.Password = textBox2.Text;
            user.Id = Convert.ToInt32(textBox3.Text);
            if (user != null)
            {

            }
            else
            {
                MessageBox.Show("Неудалось добавить пользователя", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
