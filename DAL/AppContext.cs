using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.DAL {
    public class AppContext : DbContext {
        private string ConnectionString { get; }
        public DbSet<User> Users { get; set; }

        public AppContext() {
            //Database.EnsureCreated();
            ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=testdb;Trusted_Connection=True;";
        }
        public AppContext(string connectionstring) {
            ConnectionString = connectionstring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
