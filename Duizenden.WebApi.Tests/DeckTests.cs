using Duizenden.WebApi.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Duizenden.WebApi.Tests {
    [TestClass]
    public class DeckTests {
        [TestMethod]
        public void CreateDeck_CompleteDeckWithJokers() {
            var d = new Deck();

            var expectedJokerCount = 2;
            var expectedCardCount = 52;
            var actualJokerCount = 0;

            var uniqueCardList = new List<Tuple<Suit, Rank>>();

            foreach (var card in d.Cards) {
                if (card.Suit == Suit.Joker) {
                    actualJokerCount++;
                    continue;
                } else {
                    var existingCard = uniqueCardList.FirstOrDefault(c => c.Item1 == card.Suit && c.Item2 == card.Rank);
                    if (existingCard == null) {
                        var rankSuitCombo = Tuple.Create(card.Suit, card.Rank);
                        uniqueCardList.Add(rankSuitCombo);
                    } else {
                        // Double card, don't add
                    }
                }
            }

            Assert.AreEqual(expectedJokerCount, actualJokerCount);
            Assert.AreEqual(expectedCardCount, uniqueCardList.Count);
        }
    }
}
