using System;

// Task Description:
// Write a program that reads an integer from the console, uses an expression to check if it is odd or even,
// and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int number;
            number = int.Parse(Console.ReadLine());

            Console.Clear();
            if (number % 2 == 0)
            {
                Console.WriteLine("even " + number);
            }
            else
            {
                Console.WriteLine("odd " + number);
            }
            Console.ReadKey(true);
        }
    }
}
