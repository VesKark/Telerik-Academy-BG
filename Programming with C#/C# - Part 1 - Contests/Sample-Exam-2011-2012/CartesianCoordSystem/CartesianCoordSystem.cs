using System;

/* Task Description:
You are given a two-dimensional Cartesian coordinate system and the two coordinates (X and Y) of a point in the coordinate system.
The coordinate system is divided by 2 lines (x-line, y-line) which divide the plain in four parts. Each of these parts contains a lot
of points that are numbered between 1 and 4. The point where our lines are crossing is with coordinates: X=0 and Y=0.
As a result this point is numbered 0. The points on the y- and x-lines are also numbered with respectivly the numbers 5 and 6.

Input: The Input data is being read from the console. 
    The number X is on the first input line.
    The number Y is on the second input line.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
Output: The output data must be printed on the console.
    On the only output line you must print an integer number between 0 and 6, depending on the location of the given point in the coordinate system.
Constraints:
    The numbers X and Y are numbers between -2 000 000 000 001 337 and 2 000 000 000 001 337, inclusive. */

class CartesianCoordSystem
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.Write(0);
        }
        if (x == 0 && y != 0)
        {
            Console.Write(5);
        }
        if (y == 0 && x != 0)
        {
            Console.Write(6);
        }
        if (y > 0 && x > 0)
        {
            Console.Write(1);
        }
        if (y > 0 && x < 0)
        {
            Console.Write(2);
        }
        if (y < 0 && x > 0)
        {
            Console.Write(4);
        }
        if (y < 0 && x < 0)
        {
            Console.Write(3);
        }
    }
}

