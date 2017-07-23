using System;

namespace Library
{
    public class DealOneCard : Action
    {
        private readonly Dealer _dealer;
        private readonly Players _players;

        public DealOneCard(Dealer dealer, Players players)
        {
            _dealer = dealer;
            _players = players;
        }

        public void Act()
        {
            throw new NotImplementedException();
        }

        public bool Finished()
        {
            throw new NotImplementedException();
        }
    }
}