using System;

// Task Description:
// Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values
// if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B,
// separated by a whitespace.
// Constraints - A and B will always be valid real numbers between -100 and 100.

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            if (numberA >= -100 && numberA <= 100 && numberB >= -100 && numberB <= 100)
            {
                if (numberA > numberB)
                {
                    double numberC = numberA;
                    numberA = numberB;
                    numberB = numberC;
                    Console.WriteLine(numberA + " " + numberB);
                }
                else
                {
                    Console.WriteLine(numberA + " " + numberB);
                }
            }
        }
    }
}
