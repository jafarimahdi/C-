using System;
using ModuleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModuleApp.Repository
{
    class UserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
            users.Add(new User()
            {
                UserId = 1,
                UserName="admin",
                Password="123",
                MobileNumber="03244284668",
                Email ="Mahdijafari.mj@gmail.com",
                IsActive=true,
                UserRole=Role.Admin,

            });

        }

        public void AddEmployee(User user)
        {
            users.Add(user);
            Console.WriteLine(" User Ragistered");
        }


        public void DeleteUser(int userId)
        {
           var user = users.FirstOrDefault(t => t.UserId == userId);
            if(user != null)
            {
                users.Remove(user);
                Console.Write("user has been deleted ");
            }
            else
            {
                Console.WriteLine("not found it");
            }
        }

        public void ShowAllUsers()
        {
            users.ForEach(item => Console.WriteLine(item));
            Console.ReadKey();
        }

        public int GetUsersCount()
        {
            return users.Count;
        }

        public bool Login(string userName, string password)
        {
           return users.Any(t => t.UserName.Equals(userName) && t.Password.Equals(password));
        }
    }
}

