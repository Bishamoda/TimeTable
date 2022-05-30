using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableV1.Models;
using TimeTableV1.Repositories;

namespace TimeTableV1.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersReposirory _usersRepository;
        public UsersService(IUsersReposirory usersReposirory)
        {
            _usersRepository = usersReposirory;
        }
        public User CreateUser(User users)
        {
            return users == null ? null : _usersRepository.CreateUser(users);
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _usersRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User users)
        {
            throw new NotImplementedException();
        }
    }
}
