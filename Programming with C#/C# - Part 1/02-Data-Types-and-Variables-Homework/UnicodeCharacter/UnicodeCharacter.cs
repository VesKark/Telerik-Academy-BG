using System;

// Task Description:
// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal)
// using the \u00XX syntax, and then print it.

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            int symbol = '\u002A';
            char symbolView = (char)symbol;

            Console.WriteLine(symbolView);                        
        }
    }
}
