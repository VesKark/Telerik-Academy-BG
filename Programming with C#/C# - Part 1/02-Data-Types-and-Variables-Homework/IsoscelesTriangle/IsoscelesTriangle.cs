using System;

// Task Description:
// Write a program that prints an isosceles triangle of 9 copyright symbols.

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyright = '\u00A9';

            Console.WriteLine("    " + copyright + "\n   " + copyright + " " + copyright);
            Console.WriteLine("  " + copyright + "   " + copyright);
            Console.WriteLine(" " + copyright + " " + copyright + " " + copyright + " " + copyright);
        }
    }
}
