using System;

namespace SimpleReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far, far away";


            // I would like to replace "dishwasher" with "galaxy" in this `example` variable
            // but there is an issue in the code above
            // Please fix it for me!

            //example.Replace("dishwasher", "galaxy");
            //Console.WriteLine(example);

            // Expected output: In a galaxy far, far away

            var result = example.Replace("dishwasher", "galaxy");
            Console.WriteLine(result);

        }
    }
}

