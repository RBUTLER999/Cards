using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap
{
    public class AllCardsStillInMiddle : IShuffle, ICards
    {
        private IShuffle _shuffler;
        private List<Pack> packs = new List<Pack>();
        private List<Card> cardsInMiddle = new List<Card>();

        public AllCardsStillInMiddle(IShuffle shuffler, int numPacks)
        {
            _shuffler = shuffler;

            for (int i = 0; i < numPacks; i++)
            {
                packs.Add(new Pack());
            }

            foreach (Pack pack in packs)
            {
                while (pack.CardsRemaining > 0)
                {
                    cardsInMiddle.Add(pack.TakeCard());
                }
            }

            cardsInMiddle = shuffler.Shuffle(cardsInMiddle);
        }

        public List<Card> Shuffle(List<Card> cards)
        {
            return _shuffler.Shuffle(cards);
        }

        public int CardsRemaining
        {
            get { return cardsInMiddle.Count; }
        }

        public Card TakeCard()
        {
            Card lastCard = cardsInMiddle.Last();
            cardsInMiddle.Remove(lastCard);
            return lastCard;
        }
    }
}
