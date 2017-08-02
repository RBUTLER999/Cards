namespace Snap
{
    public interface ICards
    {
        int CardsRemaining { get; }

        Card TakeCard();
    }
}