using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {

            // We are going to represent our expenses in a list containing integers:

            //Create a list with the following items:
            //500, 1000, 1250, 175, 800 and 120
            //Create an application which prints out the answers to the following questions:
            //How much did we spend?
            //Which was our greatest expense?
            //Which was our cheapest spending?
            //What was the average amount of our spendings ? (print this as a float value)

            List<int> Personalfinance = new List<int>(){
                500, 1000, 1250, 175, 800,120
            };


        }
    }
}

