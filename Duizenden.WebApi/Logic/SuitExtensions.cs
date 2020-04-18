using System;

namespace Duizenden.WebApi.Logic {
    public static class SuitExtensions {
        public static bool IsValid(this Suit suit) {
            if (suit == Suit.Unknown) return false;
            if (!Enum.IsDefined(typeof(Suit), suit)) return false;
            return true;
        }
    }
}
