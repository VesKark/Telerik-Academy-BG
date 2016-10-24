using System;

// Task Description:
// Write an expression that calculates trapezoid's area by given sides A and B and height H. The three values should be
// read from the console in the same order. All three value will be floating-point numbers in the range [-500, 500].
// The Output will be a single line containing a single value - the area of the trapezoid.
// Output the area with exactly 7-digit precision after the floating point.

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double heightH = double.Parse(Console.ReadLine());

            double areaTrapez = (sideA + sideB) / 2 * heightH;

            string result = areaTrapez.ToString("F7");
            Console.WriteLine(result);
        }
    }
}
