using System;
using Library;

namespace TestApp
{
    public class DummyPlayer : Player
    {
        private readonly string name;

        public DummyPlayer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void AddCard(Card card)
        {
            throw new NotImplementedException();
        }

        public Player Create(string name)
        {
            return new DummyPlayer(name);
        }

        public Card ShowCard()
        {
            throw new NotImplementedException();
        }
    }
}