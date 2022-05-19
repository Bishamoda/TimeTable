using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.BL
{
    public  interface ILoginService
    {
        bool CheckUser(string name, string password);
    }
}
