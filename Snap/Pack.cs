using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Snap
{
    public class Pack : ICards
    {
        private List<Card> cards = new List<Card>(52);

        public Pack()
        {
            Setup();
        }
        
        private void Setup()
        {
            foreach (Enums.Suit suit in Enum.GetValues(typeof(Enums.Suit)))
            {
                for (int i = 2; i <= 14; i++)
                {
                    cards.Add(new Card
                    {
                        Suit = suit,
                        Value = CardValue(i)
                    });
                }
            }
        }

        private string CardValue(int i)
        {
            if (i<=10)
            {
                return i.ToString();
            }

            switch (i)
            {
                case 11:return "J";
                case 12:return "Q";
                case 13: return "k";
                case 14: return "A";
            }

            return "0";
        }

        public int CardsRemaining
        {
            get { return cards.Count; }
        }
        public Card TakeCard()
        {
            Card lastCard = cards.Last();
            cards.Remove(lastCard);
            return lastCard;
        }
    }
}
