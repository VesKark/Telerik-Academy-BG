using System;

// Task Description:
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight W (as a floating-point number) on the Earth.
// The weight W should be read from the console with exactly 3-digit precision after the floating point. 

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());
            
            float percantage = 0.17f;
            float weightOnMoon = weight * percantage;

            string output = weightOnMoon.ToString("0.000");

            Console.WriteLine(output);
        }
    }
}
