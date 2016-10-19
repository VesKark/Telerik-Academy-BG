using System;

// Task Description:
// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
// 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them
// to ensure no precision is lost.

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double NumberOne = 34.567839023;
            float NumberTwo = 12.345f;
            double NumberThree = 8923.1234857;
            float NumberFour = 3456.091f;

            Console.WriteLine(NumberOne);
            Console.WriteLine(NumberTwo);
            Console.WriteLine(NumberThree);
            Console.WriteLine(NumberFour);
        }
    }
}
