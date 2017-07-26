using System;
using System.Linq;

namespace Library
{
    public class DealOneCard : Action
    {
        private readonly Dealer _dealer;
        private readonly Players _players;
        private bool _finished;

        public DealOneCard(Dealer dealer, Players players)
        {
            _dealer = dealer;
            _players = players;
            _finished = false;
        }

        public void Act()
        {
            _players.All(x => x.AddCard(_dealer.DealCard()));
            _finished = true;
        }

        public bool Finished()
        {
            return _finished;
        }
    }
}