using System.Collections.Generic;
using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Pokergame
    {
        private Players players;
        private Player player;

        public Pokergame()
        {
            players = new PokerPlayers();
        }

        public Players Players
        {
            get
            {
                return players;
            }
        }

        public void AddPlayer(string playerName)
        {

            players.AddPlayer(CreateNewPlayer(playerName));
        }

        private Player CreateNewPlayer(string name)
        {
            return new PokerPlayer(name);
        }
    }
}