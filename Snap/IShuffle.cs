using System.Collections.Generic;

namespace Snap
{
    public interface IShuffle
    {
        List<Card> Shuffle(List<Card> cards);
    }
}