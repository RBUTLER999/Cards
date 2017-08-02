using System;
using System.Collections.Generic;

namespace Snap
{
    public class FusherYatesShuffle : IShuffle
    {
        public List<Card> Shuffle(List<Card> cards)
        {
            // https://stackoverflow.com/questions/17122417/making-a-shuffle-method
         
            List<Card> Shuffeled = new List<Card>();
            int count = cards.Count;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                var selection = rand.Next(cards.Count - 1);
                Shuffeled.Add(cards[selection]);
                cards.RemoveAt(selection);
            }
            return Shuffeled;
        }
    }
}