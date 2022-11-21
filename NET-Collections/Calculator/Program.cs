using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads parameters from the prompt and prints the result back.
            // The calculator should support the following operators: +, -, *, /, %
            // The format of the input expressions must be: {operator} {operand} {operand}
            // Input examples:
            //    "+ 3 3" (the result will be 6)
            //    "* 4 4" (the result will be 16)
            //    "/ 4 3" (the result will be 1)
            //
            // In the division (/) case, the result should be a whole number, e.g. 20 / 8 = 2, 10 / 3 = 3, etc.

            // To make it work use `Console.ReadLine` to get input from the user. Create a method named `Calculate()`
            // and pass the input as a parameter into it. The method should return a result of the calculation as an
            // integer.
            //
            // The process should work like this:
            // - Start the program
            // - Print: "Please type in the expression:" using Console.WriteLine
            //   (Wait for the user input)
            // - After receiving the input print the result number to the prompt
            // - Exit the program

            // Input & Output
            //
            // Please type in the expression:
            // + 10 3
            // 13


            Console.WriteLine("please add your numbers in format {operator} {operand} {operand}");
            string userInput = Console.ReadLine();

            Console.WriteLine(Calculate(userInput));
        }


        public static int Calculate(string input)
        {
            //convert user input as string to array
            var convertToArray = input.Split(" ");

            // use switch to make sure wich mate option to use + - % *
            string findOperator = convertToArray[0];

            //Convert the other string to number format for calculate
            int firstOperand = int.Parse(convertToArray[1]);
            int secondOperand = int.Parse(convertToArray[2]);

            int result = 0;

            switch (findOperator)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "%":
                    result = firstOperand % secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
            }
            return result;
        }
    }
}

