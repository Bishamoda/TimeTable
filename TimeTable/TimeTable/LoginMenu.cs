using System;
using System.Windows.Forms;
using TimeTable.BL;
using TimeTable.DataAccess;

namespace TimeTable
{
    public partial class LoginMenu : Form
    {
        private readonly ILoginService _loginService;
        User user = new User();
        public LoginMenu()
        {
            InitializeComponent();
        }

        public LoginMenu(ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            user.UserName = textBox1.Text;
            user.Password = textBox2.Text;
            if (user.UserName == "Mikhail" && user.Password == "123")
            {
                using (MainMenu menu = new MainMenu(user))
                {
                    DialogResult dr = menu.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
