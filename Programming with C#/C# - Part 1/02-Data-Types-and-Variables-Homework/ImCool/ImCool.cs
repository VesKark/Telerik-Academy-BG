using System;

namespace ImCool
{
    class ImCool
    {
        static void Main()
        {
            string amICool = "Absolutely";

            Console.WriteLine("Am I cool? \nPress enter to find out!");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key.Equals(ConsoleKey.Enter))
            Console.WriteLine(amICool);

            Console.ReadKey(true);
        }
    }
}
