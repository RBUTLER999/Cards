using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDecks;
            Console.WriteLine("How many decks?");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out numDecks))
            {
                Console.WriteLine("Needs to be a number");
            }
            
            AllCardsStillInMiddle allCardsStillInMiddle = new AllCardsStillInMiddle(new FusherYatesShuffle(), numDecks);

            // quick check everythign working so far
            while (allCardsStillInMiddle.CardsRemaining > 0)
            {
                Card card = allCardsStillInMiddle.TakeCard();

                Console.WriteLine(card);
            }

            Console.ReadKey();
        }
    }
}
