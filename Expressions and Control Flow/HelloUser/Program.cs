using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User

            Console.WriteLine("Please Enter Your Name");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}");
        }
    }
}

