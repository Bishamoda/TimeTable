using System;
using System.Windows.Forms;
using TimeTable.DataAccess;

namespace TimeTable
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {

        }

        public MainMenu(User user)
        {
            InitializeComponent();
            monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            label2.Text = String.Format($"{user.UserRole}, {user.UserName}");
            label4.Text = String.Format($"{DateTime.UtcNow}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            using (LoginMenu loginMenu = new LoginMenu())
            {
                DialogResult dr = loginMenu.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    loginMenu.Close();
                }
            }
        }
    }
}
