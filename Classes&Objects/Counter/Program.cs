using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Counter class
            // which has a counter(integer) field
            // at creation it should have a default value 0
            // there are two ways to create the class:
            // with 0 input parameters
            // with 1 input parameter called counter which is set as the initial value of the counter field
            // we can add another whole number to this counter: Add(number)
            // we can just increase the counter's value by one: Add() (no parameters)
            // we can Get() the current counter value
            // and we can Reset() the counter to the initial value set during the construction of the class

            Counter firstCounter = new Counter(1);
            firstCounter.Add(12);
            Console.WriteLine(firstCounter.Get());

            firstCounter.Reset();
            Console.WriteLine(firstCounter.Get());


        }
    }
}

