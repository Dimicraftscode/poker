using System.Collections.Generic;
using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Pokergame
    {
        private readonly Players _players;
        private readonly int _maxPlayers;
        //private Player player;

        public Pokergame()
        {
            _maxPlayers = 2;
            _players = new PokerPlayers(_maxPlayers);
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
            return new PokerPlayer(name);
        }
    }
}