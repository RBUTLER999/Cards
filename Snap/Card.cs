namespace Snap
{
    public class Card
    {
        public string Value { get; set; }

        public Enums.Suit Suit { get; set; }

        public override string ToString()
        {
            return Suit + ":" + Value;
        }
    }
}
