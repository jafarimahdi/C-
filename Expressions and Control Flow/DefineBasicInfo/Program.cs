using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "Mahdi";
            int age = 33;
            double height = 1.83;
            bool married = false;


            Console.WriteLine($"{name} {age} {height} {married}");
        }
    }
}

