using System;

// Task Description:
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number1;
            double? number2;

            number1 = null;
            number2 = null;
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + null;
            number2 = number2 + null;
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + 100;
            number2 = number2 + 100.5;
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + 100;
            number2 = number2 + 100.5;
            Console.WriteLine("{0};{1}", number1.GetValueOrDefault(), number2.GetValueOrDefault());
        }
    }
}
