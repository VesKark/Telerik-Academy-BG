using System;

// Task Description:
// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
// Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
// Input - On the only line you will receive a single string.
// Constraints - String length will always be between 1 and 5.

namespace PlayCardCheck
{
    class PlayCardCheck
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int cardNumber;

            if (int.TryParse(card, out cardNumber))
            {
                if (cardNumber >= 2 && cardNumber <= 10)
                {
                    Console.WriteLine("yes " + cardNumber);
                }
                else
                {
                    Console.WriteLine("no " + cardNumber);
                }
            }                   

            else
            {
                switch (card)
                {
                    case "J":
                        Console.WriteLine("yes " + card);
                        break;
                    case "Q":
                        Console.WriteLine("yes " + card);
                        break;
                    case "K":
                        Console.WriteLine("yes " + card);
                        break;
                    case "A":
                        Console.WriteLine("yes " + card);
                        break;
                    default:
                        Console.WriteLine("no " + card);
                        break;
                }
            }
        }
    }
}
