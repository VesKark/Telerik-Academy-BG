using System;

// Task Description:
// Write a program that does the following:
// Reads an integer number from the console.
// Stores in a variable if the number can be divided by 7 and 5 without remainder.
// Prints on the console "true NUMBER" if the number is divisible without remainder by 7 AND 5.
// Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.

namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.Clear();
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("true " + number);
            }
            else
            {
                Console.WriteLine("false " + number);
            }
            Console.ReadKey(true);
        }
    }
}
