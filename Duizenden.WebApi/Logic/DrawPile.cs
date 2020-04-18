using System.Collections.Generic;

namespace Duizenden.WebApi.Logic {
    public sealed class DrawPile {
        List<Card> _pile = new List<Card>();

        public Card GetNext() {
            var indexNextCard = ThreadSafeRandom.ThisThreadsRandom.Next(0, _pile.Count);
            var nextCard = _pile[indexNextCard];
            _pile.RemoveAt(indexNextCard);
            return nextCard;
        }
    }
}
