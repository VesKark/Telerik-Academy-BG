using System;

// Task Description:
// Write a program that reads your age from the console and prints
// on the console how old will you be after 10 years.

namespace AgeInTenYears
{
    class AgeInTenYears
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: {0}.", Age + 10);
        }
    }
}
