using System.Collections.Generic;
using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Pokergame : Game
    {
        private readonly Players _players;
        private readonly int _maxPlayers;
        private readonly Player _player;

        public Pokergame(Players players, Player player)
        {
            _maxPlayers = 2;
            _players = players;
            _player = player;
        }

        public Players Players
        {
            get
            {
                return _players;
            }
        }

        public void AddPlayer(string playerName)
        {

            _players.AddPlayer(CreateNewPlayer(playerName));
        }

        private Player CreateNewPlayer(string name)
        {

            return _player.Create(name);
        }
    }
}