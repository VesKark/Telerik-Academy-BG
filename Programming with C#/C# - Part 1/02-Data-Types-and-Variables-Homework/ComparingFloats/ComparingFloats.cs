using System;
using System.Threading;
using System.Globalization;

// Task Description:
// Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
// On the first line you will receive the first floating-point number. On the second line - the second.
// Print "true" if the numbers are equal or "false" if they are not.


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            // fix the decimal point to "."
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Abs(firstInput - secondInput);
            Math.Round(difference, 6);
            
            if (difference > eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
