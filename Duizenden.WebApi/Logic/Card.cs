using System;

namespace Duizenden.WebApi.Logic {
    public sealed class Card {
        public Card(Suit suit, Rank rank) {
            if (!suit.IsValid()) throw new ArgumentNullException(nameof(suit), $"{suit} is not a valid suit.");
            if (!rank.IsValid()) throw new ArgumentNullException(nameof(rank), $"{rank} is not a valid rank.");

            Suit = suit;
            Rank = rank;
        }

        public Suit Suit { get; }
        public Rank Rank { get; }

        public int Score {
            get {
                if (Rank == Rank.Queen && Suit == Suit.Spades) {
                    return 100;
                }

                if (Rank == Rank.Two ||
                   Rank == Rank.Three ||
                   Rank == Rank.Four ||
                   Rank == Rank.Five ||
                   Rank == Rank.Six ||
                   Rank == Rank.Seven ||
                   Rank == Rank.Eight ||
                   Rank == Rank.Nine) {
                    return 5;
                }

                if (Rank == Rank.Ten ||
                   Rank == Rank.Jack ||
                   Rank == Rank.Queen ||
                   Rank == Rank.King) {
                    return 10;
                }

                if (Rank == Rank.Ace) {
                    return 20;
                }

                if (Suit == Suit.Joker) {
                    return 25;
                }

                throw new Exception();
            }
        }
    }
}
