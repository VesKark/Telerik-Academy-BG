using System;

// Task Description:
// Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) if it is
// within the circle K ({1, 1}, 1.5) and out of the rectangle R ({-1, 1}=top left, {5, -1}=bottom right).
// Input - You will receive the pair of coordinates on the two lines of the input - on the first line is x, on the second - y.
// Output - Print "inside circle" if the point is inside the circle and "outside circle" if it's outside.
// Then print a single whitespace followed by "inside rectangle" if the point is inside the rectangle and "outside rectangle" otherwise.
// Constrains - The coordinates x and y will always be valid floating-point numbers in the range[-1000, 1000].

namespace PointCircleRectangle
{
    class PointCircleRectangle
    { 
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // defining the Circle:
            int x0 = 1;
            int y0 = 1;
            double rr = (x - x0) * (x - x0) + (y - y0) * (y - y0);
            double r = 1.5;
            
            if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
            {
                bool isInCircle = rr <= r * r;
                bool isInRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

                if (isInCircle && isInRectangle)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                if (!isInCircle && isInRectangle)
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
                if (isInCircle && !isInRectangle)
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
                if (!isInCircle && !isInRectangle)
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
            }
        }
    }
}