using System;

// Task Description:
// Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and
// formatted with 2 digits after the decimal point.
// Output - You should print one line only: the perimeter and the area of the circle, separated by a whitespace (2 digits precision).

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * radius * radius;
            double perimeterCircle = 2 * Math.PI * radius;

            Console.WriteLine("{0:0.00} {1:0.00}", perimeterCircle, areaCircle);
        }
    }
}
