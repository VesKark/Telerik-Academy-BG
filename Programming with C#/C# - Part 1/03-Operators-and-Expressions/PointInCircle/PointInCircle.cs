using System;

// Task Description:
// Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y)
// is inside a circle K ({ 0, 0}, 2). The center has coordinates (0, 0) and the circle has radius 2.
// The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is
// outside the circle. In place of DISTANCE print the distance from the beginning of the coordinate system (0, 0) to
// the given point. The distance should be always printed with 2-digit precision after the floating point.

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double cc = (a * a) + (b * b);
            double c = Math.Sqrt(cc);

            string outputC = c.ToString("0.00");

            if (cc <= 4)
            {
                Console.WriteLine("yes " + outputC);
            }
            else
            {
                Console.WriteLine("no " + outputC);
            }
        }
    }
}
