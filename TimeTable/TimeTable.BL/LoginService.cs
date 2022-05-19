using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.DataAccess;

namespace TimeTable.BL
{
    public class LoginService : ILoginService
    {
        public bool CheckUser(string name, string password)
        {
            if (name == "Mikhail" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
