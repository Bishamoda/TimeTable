using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableV1.Models;
using System.Data.SqlClient;

namespace TimeTableV1.Data
{
    public class DBContext : DbContext
    {
        private const string ConnectionString = @"Server=(localdb)\TimeTable;Database=TimeTable;Integrated Security=True";
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
