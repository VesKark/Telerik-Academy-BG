using System;

/* Task Description:
Write a computer program that finds the number of the cat (from 10 cats all together) that is going to win the competition
"Miss Cat", i.e. has gathered the most jury votes (from N members of the jury).
Input: The input data is being read from the console.
    The number N is on the first input line.
    An integer between 1 and 10 is written on each of the next N lines (this is the number of the cats).
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    If two cats have equal votes, the winner of the contest is the one whose number is smaller.
Output: The output data must be printed on the console.
    On the only output line you must print the number of the cat, which has won the competition. 
Constraints:
    The number N is a positive integer between 1 and 100 000, inclusive.
    The numbers of the cats for which the jury votes are positive integer numbers between 1 and 10, inclusive. */

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] votes = new int[n];           

        for (int i = 0; i < n; i++)
        {
            votes[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(votes);

        int counter = 1;
        int result = 0;
        int winnerCat = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (votes[i] == votes[i + 1])
            {
                counter++;                  
            }
            else
            {
                if (counter > result)
                {
                    result = counter;
                    winnerCat = votes[i];
                }
                counter = 1;
            }
        }
            
        if (counter > result)
        {
            result = counter;
            winnerCat = votes[votes.Length - 1];
        }
        Console.WriteLine(winnerCat);
    }
}

