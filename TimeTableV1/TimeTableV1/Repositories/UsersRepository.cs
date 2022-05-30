using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableV1.Data;
using TimeTableV1.Models;

namespace TimeTableV1.Repositories
{
    public class UsersRepository : IUsersReposirory
    {
        private readonly DBContext _dB;
        public UsersRepository(DBContext dBContext)
        {
            _dB = dBContext;
        }
        public User CreateUser(User users)
        {
            _dB.Users.Add(users);
            _dB.SaveChanges();
            return users;
        }

        public User DeleteUser(int id)
        {
            User user = _dB.Users.Find(id);
            _dB.Users.Remove(user);
            _dB.SaveChanges();
            return user;
        }

        public IEnumerable<User> GetAllUsers() => _dB.Users.OrderBy(u => u.Id);

        public User GetUserById(int id)
        {
            return _dB.Users.Single(u => u.Id == id);
        }

        public User UpdateUser(User users)
        {
            _dB.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dB.SaveChanges();
            return users;
        }
    }
}
