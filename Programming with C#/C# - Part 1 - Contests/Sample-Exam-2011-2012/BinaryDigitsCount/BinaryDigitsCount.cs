using System;

/* Task Description:
You are given a sequence of N positive integer numbers and one binary digit B (0 or 1). Your task is to write a program that finds
the number of binary digits (B) in each of the N numbers in binary numeral system. Example: 20 in the binary numeral system looks
like this: 10100. The count of digits 0 of the number 20 in the binary numeral system is 3.
Input:
    The input data is being read from the console. 
    On the first input line there will be the digit B.
    On the second line you must read the number N.
    On each of the following N lines there is one positive integer number written – the consequent number, whose sum of binary
    digits B we are searching for.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
Output:
    The output must be printed on the console.
    In the output you must have N lines. Each line must have 1 integer number – the number of digits B in the binary representation
    of the given consequent number.
Constraints:
    Number N is a positive integer between 1 and 1000, inclusive.
    Each of the N numbers is a positive integer between 1 and 4 000 000 000, inclusive.
    The digit B will be only 0 or 1.  */

class BinaryDigitsCount
{
    static void Main()
    {
        int inputB = int.Parse(Console.ReadLine());        
        uint numN = uint.Parse(Console.ReadLine());
        uint[] seqN = new uint[numN];

        for (uint n = 0; n < seqN.Length; n++)
        {
            seqN[n] = uint.Parse(Console.ReadLine());
        }        
        

        for (int i = 0; i < seqN.Length; i++)
        {
            int countBitsOnes = 0;
            int countBitsZeroes = 0;

            while (seqN[i] != 0)
            {
                if ((seqN[i] & 1) == 1)
                {
                    countBitsOnes++;
                }
                else
                {
                    countBitsZeroes++;
                }
                seqN[i] >>= 1;
            }

            if (inputB == 1)
            {
                Console.WriteLine(countBitsOnes);
            }
            else
            {
                Console.WriteLine(countBitsZeroes);
            }
        }
    }
}

