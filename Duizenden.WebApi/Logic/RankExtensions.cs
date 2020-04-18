using System;

namespace Duizenden.WebApi.Logic {
    public static class RankExtensions {
        public static bool IsValid(this Rank rank) {
            if (rank == Rank.Unknown) return false;
            if (!Enum.IsDefined(typeof(Rank), rank)) return false;
            return true;
        }
    }
}
