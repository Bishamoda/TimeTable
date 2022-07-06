

namespace TimeTableV1
{
    public partial class TimeTable : Form
    {
        private readonly string _userName;
        public TimeTable(string name)
        {
            InitializeComponent();
            _userName = name;
            labelName.Text = $"Здравствуйте, {_userName}";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Hide();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {

        }
    }
}