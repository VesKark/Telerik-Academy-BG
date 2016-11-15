using System;

/* Task Description:
    You are given a list of N numbers. Write a program that counts all non-empty subsets from this list, which have sum of their elements exactly S.
Example: if you have a list with 4 elements: { 1, 2, 3, 4 } and you are searching the number of non-empty subsets which sum is 4, the answer will be 2.
The subsets are: { 1, 3 } and { 4 }.
Input:
    The input data is being read from the console. On the first input line there will be the number S. On the second line you must read the number N.
    On each of the following N lines there will be one integer number written – all the numbers from the list.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
Output:
    The output must be printed on the console.
    On the only output line you must print the number of the non-empty subsets, which have sum of all its elements exactly S.
Constraints:
    The number N is a positive integer between 1 and 16, inclusive.
    All of the N numbers are integer numbers and will be between -1 337 000 000 000 and 1 337 000 000 000, inclusive.
    The number S is an integer number between -21 392 000 000 000 and 21 392 000 000 000, inclusive.
    All of the N numbers will be distinct.  */

class SubsetSums
{
    static void Main()
    {
        long numS = long.Parse(Console.ReadLine());
        int numN = int.Parse(Console.ReadLine());
        long[] arrayN = new long[numN];

        for (int i = 0; i < numN; i++)
        {
            arrayN[i] = long.Parse(Console.ReadLine());
        }
        
        int counter = 0;

        for (int i = 1; i < Math.Pow(2, numN); i++)
        {
            if (numS == CalculateSum(i, arrayN))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }

    static long CalculateSum(int subSet, long[] arrayN)
    {
        long sum = 0;
        for (int i = 0; i < arrayN.Length; i++)
        {
            int bit = (subSet & (1 << i)) >> i;
            sum += arrayN[i] * bit;
        }
        return sum;
    }
}

