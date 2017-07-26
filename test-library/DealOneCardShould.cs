using FluentAssertions;
using Library;
using Moq;
using Xunit;
using System.Linq;
using System;
using System.Collections.Generic;

namespace TestApp
{
    public class DealOneCardShould
    {
        private Card TESTCARD = new PlayingCard("Q", "h");
        private Library.Action _dealOneCard;
        private Players _players;

        public DealOneCardShould()
        {
            var dealer = new Mock<Dealer>();
            dealer.Setup(d => d.DealCard()).Returns(TESTCARD);
            _players = DummyPlayers;
            _dealOneCard = new DealOneCard(dealer.Object, _players);
        }

        [Fact]
        public void BeInstantiated()
        {
            _dealOneCard.Should().NotBeNull();
        }

        [Fact]
        public void DealOneCardToEveryOne()
        {
            _dealOneCard.Act();
            _players.Players().All(p => p.ShowCard() == TESTCARD).Should().BeTrue();
            //check players have card to be all one
        }

        [Fact]
        public void StartUnfinished()
        {
            _dealOneCard.Finished().Should().BeFalse();
        }

        [Fact]
        public void BeFinishedAfterAct()
        {
            _dealOneCard.Act();
            _dealOneCard.Finished().Should().BeTrue();
        }

        private TestPlayers DummyPlayers
        {
            get
            {
                var tp = new TestPlayers();
                tp.AddPlayer(new TestPlayer("Test 1"));
                tp.AddPlayer(new TestPlayer("Test 2"));
                return tp;
            }
        }

        internal class TestPlayers : Players
        {
            private readonly List<Player> _players;

            internal TestPlayers()
            {
                _players = new List<Player>();
            }
            public void AddPlayer(Player player)
            {
                _players.Add(player);
            }

            public void All(Action<Player> pred)
            {
                _players.ForEach(pred);
            }

            public IEnumerable<Player> Players()
            {
                return _players;
            }

            public void RemovePlayer(Player player)
            {
                _players.Remove(player);
            }
        }

        internal class TestPlayer : Player
        {
            public string Name { get; private set; }
            private Card _card;

            internal TestPlayer(string name)
            {
                Name = name;
            }
            public void AddCard(Card card)
            {
                _card = card;
            }

            public Player Create(string name)
            {
                return new TestPlayer(name);
            }

            public Card ShowCard()
            {
                return _card;
            }
        }
    }
}