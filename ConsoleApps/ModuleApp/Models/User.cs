using System;
namespace ModuleApp.Models
{

    enum Role
    {
        Admin, Employee
    }

    class User
    {

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string MobileNumber { get; set; }

        public Role UserRole { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t\t{1}\t\t{2}\t\t{3}", UserId, UserName, UserRole, IsActive);
        }
    }
}

