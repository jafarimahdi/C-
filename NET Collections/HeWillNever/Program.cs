using System;
using System.Collections.Generic;
using System.Linq;

namespace HeWillNever
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you");
            map.Add(49, "make you cry, ");
            map.Add(2, "let you down");
            map.Add(12, "give you up, ");
            map.Add(1, "Never gonna ");
            map.Add(11, "\n");
            map.Add(3, "say goodbye");

            // Things are a bit messed up here
            // Your job is to decode the `notSoCrypticMessage` by using the hashmap as a lookup table
            // Assemble the fragments into the `output` variable

            // Expected output:
            // Never gonna give you up, Never gonna let you down
            // Never gonna run around and desert you
            // Never gonna make you cry, Never gonna say goodbye
            // Never gonna tell a lie and hurt you
            //

            makeCorrection(notSoCrypticMessage, map);
        }

        public static void makeCorrection(int[] list, Dictionary<int, string> map)
        {
            string output = "";

            foreach (int item in list)
            {
                if (map.ContainsKey(item))
                {
                    output += map[item];
                }
            }

            Console.WriteLine(output);
        }
    }
}

