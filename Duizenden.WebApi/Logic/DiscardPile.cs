using System.Collections.Generic;

namespace Duizenden.WebApi.Logic {
    public sealed class DiscardPile {
        private Stack<Card> _pile = new Stack<Card>();

        public void Discard(Card card) {
            _pile.Push(card);
        }
    }
}
