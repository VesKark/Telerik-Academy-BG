using System;

/* Task Description:
Geeko, a non-stop learning trainee at Telerik Software Academy lived deep into the Lulin forests. Every time he went to the Academy
he had to take a long trip through the forest. Starting from the top left corner of the forest, the road always goes down and right
first and when it reaches the border, it goes down and left. 
The Academy is situated in the bottom left corner.
Geeko wanted to make a program that generates a map of the forest but he couldn’t.
Help Geeko on his way to the Academy by writing the program instead of him.
Input:
    The input data is being read from the console.
    On the only line in the console you are given an integer number N, showing the width of the map.
    The map’s height is always 2*N - 1.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
Output:
    The output data must be printed on the console.
    Print the whole map on the console. Use the symbol “*” (asterisk) to mark Geeko’s path and “.” (dot) to illustrate the trees.
Constraints:
    The number N is a positive integer between 2 and 79, inclusive. */

class ForestRoad
{
    static void Main()
    {
        int mapWidth = int.Parse(Console.ReadLine());
        int mapHeight = (2 * mapWidth) - 1;

        for (int i = 0; i <= mapHeight / 2; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int i = mapHeight / 2 - 1; i >= 0 ; i--)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

