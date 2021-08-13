using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.DAL {
    public class AppRepo: IRepo {
        private readonly AppContext Context;
        public AppRepo(AppContext context) {
            Context = context;
        }

        public void AddUser(User user) {
            Context.Users.Add(user);
            Context.SaveChanges();
        }
        public IEnumerable<User> GetAllUsers() {
            return Context.Users.ToList();
        }
    }
}
