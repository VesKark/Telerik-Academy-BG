using System;

// Task Description:
//  Write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).

namespace PrintASCIItable
{
    class PrintASCIItable
    {
        static void Main()
        {                                              
            for (int i=33; i <= 126; i++)
            {
                char asc = (char) i;
                Console.Write(asc);
            }                
        }
    }
}
