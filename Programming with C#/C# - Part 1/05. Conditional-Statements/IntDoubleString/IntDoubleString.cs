﻿using System;

// Task Description:
// Write a program that, depending on the first line of the input, reads an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends* at the end.
// Print the result at the console. Use switch statement.

// Input - On the first line you will receive the type of input as string in the following form:
//     integer  (for int)
//     real     (for double)
//     text     (for string)
// On the second line you will be given the value of the variable.

// Output - Write a single line on the console - the value transformed according to the rules from the description.
// Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string inputValue = Console.ReadLine();
            
            switch (input)
            {
                case "text":
                    Console.WriteLine(inputValue + "*");
                    break;
                case "real":
                    Console.WriteLine("{0:0.00}", double.Parse(inputValue) + 1);
                    break;
                case "integer":
                    Console.WriteLine(double.Parse(inputValue) + 1);
                    break;
            }            
        }
    }
}
