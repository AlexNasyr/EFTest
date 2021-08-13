using System;
using System.Linq;
using EFTest.DAL;

namespace EFTest {
    class Program {
        static IRepo repo;
        static void Main(string[] args) {
            repo = new AppRepo(new DAL.AppContext("Server=(localdb)\\mssqllocaldb;Database=testdb;Trusted_Connection=True;"));
            // создаем два объекта User
            User user1 = new User { Name = "Tom", Age = 33 };
            User user2 = new User { Name = "Alice", Age = 26 };

            // добавляем их в бд
            //db.Users.Add(user1);
            //db.Users.Add(user2);
            //db.SaveChanges();
            repo.AddUser(user1);
            repo.AddUser(user2);
            Console.WriteLine("Объекты успешно сохранены");

            // получаем объекты из бд и выводим на консоль
            var users = repo.GetAllUsers();
            Console.WriteLine("Список объектов:");
            foreach (User u in users) {
                Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            }
            Console.Read();
        }
    }
}
