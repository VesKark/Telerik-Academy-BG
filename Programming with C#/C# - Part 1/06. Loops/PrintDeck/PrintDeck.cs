using System;

// Task Description:
// Write a program that reads a card sign (as a char) from the console and generates and prints all possible cards from a
// standard deck of 52 cards up to the card with the given sign (without the jokers). The cards should be printed using the
// classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

// Input - On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
// Output - The output should follow the format bellow (assume our input is 5):
// 2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds

// Constraints - The input character will always be a valid card sign.

namespace PrintDeck
{
    class PrintDeck
    {
        static void Main()
        {
            // Variant 01:

            string cardInput = Console.ReadLine();             

            int card;

            if (int.TryParse(cardInput, out card))
            {
                for (int i = 2; i <= card; i++)
                {
                    do
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        break;
                    }
                    while (i <= 10);
                }
            }

            else
            {
                foreach (char symbol in cardInput)
                {
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }

                    switch (symbol)
                    {
                        case 'J':
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", symbol);
                            break;
                        case 'Q':
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", symbol);
                            break;
                        case 'K':
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", symbol);
                            break;
                        case 'A':
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", symbol);
                            break;
                    }
                }
            }


            // Variant 02:

            string input = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int n = 0;

            switch (input)
            {
                case "2": n = 2; break;
                case "3": n = 3; break;
                case "4": n = 4; break;
                case "5": n = 5; break;
                case "6": n = 6; break;
                case "7": n = 7; break;
                case "8": n = 8; break;
                case "9": n = 9; break;
                case "10": n = 10; break;
                case "J": n = 11; break;
                case "Q": n = 12; break;
                case "K": n = 13; break;
                case "A": n = 14; break;
                default:
                    break;
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
            }
        }
    }
}
