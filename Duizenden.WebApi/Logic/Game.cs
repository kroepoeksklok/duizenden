using System;
using System.Collections.Generic;

namespace Duizenden.WebApi.Logic {
    public sealed class Game {
        private ICollection<Player> _players;
        private static readonly Lazy<Game> _lazy = new Lazy<Game>(() => new Game());

        public static Game Instance => _lazy.Value;

        private Game() {
            _players = new List<Player>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public Player Join(string name) {
            var player = new Player(name);
            _players.Add(player);
            return player;
        }
    }
}
