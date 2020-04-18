using System;
using System.Collections.Generic;

namespace Duizenden.WebApi.Logic {
    public sealed class Player {
        public Player(string name) {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Empty name not allowed");

            Name = name;
            Score = 0;
            Cards = new List<Card>();
        }

        public ICollection<Card> Cards { get; }
        public string Name { get; }
        public int Score { get; set; }
        public bool IsActive { get; set; }

        public void Draw(DrawPile drawPile) {
            Cards.Add(drawPile.GetNext());
        }
    }
}
