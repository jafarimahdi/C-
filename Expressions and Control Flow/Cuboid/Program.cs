using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("please add size for the Front & Back of your cuboid");
            double cuboidFrontBack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please add size for the Bottom & Top of your cuboid");
            double cuboidTopBottom = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please add size for the Left & Right of your cuboid");
            double cuboidLeftRight = Convert.ToInt32(Console.ReadLine());

            double frontSide = (cuboidFrontBack * cuboidLeftRight) * 2;

            double topBottomSide = (cuboidTopBottom * cuboidFrontBack) * 2;

            double leftRightSide = (cuboidTopBottom * cuboidLeftRight) * 2;

            double total = frontSide + topBottomSide + leftRightSide;

            Console.WriteLine($" the cubiod surface area is: {total}");


        }
    }
}

