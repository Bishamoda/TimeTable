using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableV1.Models;

namespace TimeTableV1.Services
{
    public interface IUsersService
    {
        public User CreateUser(User users);
        public User UpdateUser(User users);
        public IEnumerable<User> GetAllUsers();
        public User DeleteUser(int id);
        public User GetUserById(int id);
    }
}
