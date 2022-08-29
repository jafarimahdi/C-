using System;
using System.Collections;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // **** Basic Array

            //int[] normalArray = new int[4];
            //normalArray[0] = 1;
            //normalArray[1] = 5;
            //normalArray[2] = 7;
            //normalArray[3] = 8;

            //for (int i = 0; i < normalArray.Length; i++)
            //{
            //    Console.WriteLine(normalArray[i]);
            //};

            //Console.WriteLine("---------------------------");


            //// ****** defind in direct way 

            //int[] normalArray2 = { 2, 4, 5, 6 };

            //for (int i = 0; i < normalArray.Length; i++)
            //{
            //    Console.WriteLine(normalArray2[i]);
            //};



            // ***  Multi Dimensional Array    1- Basic and old

            //int[,] multiDimen = new int[2, 2];
            //multiDimen[0, 0] = 13;
            //multiDimen[0, 1] = 9;
            //multiDimen[1, 0] = 6;
            //multiDimen[1, 1] = 9;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(multiDimen[i, j] + " ");
            //    }

            //    Console.WriteLine();  //******* jump to the next line
            //}

            //Console.WriteLine("---------------------------");

            // 2- second way of finding the multidim

            //int[,] multiDimen2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(multiDimen2[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("---------------------------");


            // Define in direct way  -Collection Initializer         3- third way of definding multi array 

            //int[,] multiDimen3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < multiDimen2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multiDimen2.GetLength(1); j++)
            //    {
            //        Console.Write(multiDimen3[i, j] + " ");

            //    }
            //    Console.WriteLine();

            //}


            // ******** Jagged Array

            // 1- old way 

            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[4];


            //jaggedArray[0][0] = 8;
            //jaggedArray[0][1] = 3;

            //jaggedArray[1][0] = 5;
            //jaggedArray[1][1] = 9;
            //jaggedArray[1][3] = 0;
            //jaggedArray[1][3] = 83;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("---------------------------");
            //// second way of definition Collection intionalion 

            //int[][] jaggedArray2 = new int[3][];
            //jaggedArray2[0] = new int[] { 3, 5, 8, 9, 3 };
            //jaggedArray2[1] = new int[] { 1, 4, 2, 5, 6, 8, 9, 0, 4 };
            //jaggedArray2[2] = new int[] { 4, 6, 8, 9, 0, 3, 2, 4, 5 };

            //for (int i = 0; i < jaggedArray2.Length; i++)
            //{
            //    foreach (int item in jaggedArray2[i])
            //    //for (int j = 0; j < jaggedArray2[i].Length; j++)
            //    {
            //        Console.Write(item + " ");
            //        //Console.Write(jaggedArray2[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("---------------------------");



            //int[][] jaggedArray3 = new int[][]
            //{
            //new int[] { 9, 3, 3, 5, 8 },
            //new int[] { 8, 9, 0, 4, 1, 4, 2, 5, 6 },
            //new int[] { 0, 3, 2, 4 }
            //};

            //for (int i = 0; i < jaggedArray3.Length; i++)
            //{
            //    foreach (int item in jaggedArray3[i])
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}




            //  Collection     1- ArrayList
                      


            ArrayList hashmamad = new ArrayList(); // Array in Javascript 
            hashmamad.Add("fish");
            hashmamad.Add("bolani");
            hashmamad.Add(29);
            hashmamad.Add(1.73);

            foreach (var item in hashmamad)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");


            ArrayList hashmamad2 = new ArrayList() { "chicken", "beef", "ghabeli Polo", 1900, 2015 };

            ArrayList test = new ArrayList();
            foreach (var item in hashmamad2)
            {
                Console.WriteLine(item);

                test.Add(item.ToString());
            }

            foreach (var item in test)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}

