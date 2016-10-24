using System;

// Task Description:
// Write an expression that calculates rectangle’s area and perimeter by given width and height.
// The width and height should be read from the console.
// The input will consist of 2 lines:
       // On the first line, you will receive a floating-point number that will represent the width of the rectangle.
       // On the second line, you will receive another floating-point number that will represent the height of the rectangle.
// The Output a single line - the rectangle's area and perimeter, separated by a whitespace.
       // Print the area and perimeter values with exactly 2-digits precision after the floating point.

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaRect = width * height;
            double perimRect = (width + height) * 2;

            string outputArea = areaRect.ToString("0.00");
            string outputPerim = perimRect.ToString("0.00");

            Console.WriteLine(outputArea + " " + outputPerim);
        }
    }
}
