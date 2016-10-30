using System;

// Task Description:
// Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
// Use the Euclidean algorithm (find it in Internet).
// Input - On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
// Output - Output a single number - the GCD of the numbers A and B.
// Constraints - The numbers A and B will always be valid integers in the range [2, 500].

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string[] num = Console.ReadLine().Split(' ');
            int[] myNums = Array.ConvertAll(num, int.Parse);
            int remainder = 0;

            if (myNums[0] > myNums[1])
            {
                remainder = myNums[0] % myNums[1];

                while (remainder != 0)
                {
                    myNums[0] = myNums[1];
                    myNums[1] = remainder;
                    remainder = myNums[0] % myNums[1];
                }
                int gcd = myNums[1];
                Console.WriteLine(gcd);
            }

            else if (myNums[0] < myNums[1])
            {
                remainder = myNums[1] % myNums[0];

                while (remainder != 0)
                {
                    myNums[1] = myNums[0];
                    myNums[0] = remainder;
                    remainder = myNums[1] % myNums[0];
                }
                int gcd = myNums[0];
                Console.WriteLine(gcd);
            }

            else
            {
                Console.WriteLine(myNums[0]);
            }
            
        }
    }
}
