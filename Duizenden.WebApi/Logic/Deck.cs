using System;
using System.Collections.Generic;
using System.Linq;

namespace Duizenden.WebApi.Logic {
    public sealed class Deck {
        public Deck() {
            CreateDeck();
        }

        public ICollection<Card> Cards { get; private set; }

        private void CreateDeck() {
            Cards = new List<Card>();
            BuildStandardDeck();
            AddJokers();
        }

        private void BuildStandardDeck() {
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>().Where(s => s != Suit.Joker && s != Suit.Unknown);
            var ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>().Where(r => r != Rank.None && r != Rank.Unknown);

            Cards = suits.SelectMany(s => ranks, (s, r) => new Card(s, r)).ToList();
        }

        private void AddJokers() {
            Cards.Add(new Card(Suit.Joker, Rank.None));
            Cards.Add(new Card(Suit.Joker, Rank.None));
        }
    }
}
