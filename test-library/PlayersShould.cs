using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace TestApp
{
    public class PlayersShould
    {
        private Players _players;

        public PlayersShould()
        {
            _players = new PokerPlayers(2);
        }

        [Fact]
        public void PlayersCanBeCreated()
        {
            _players.Should().NotBeNull();
        }

        [Fact]
        public void NewgameHasNoPlayers()
        {
            _players.Players().Should().HaveCount(0);
        }

        [Fact]
        public void PlayerJoinsGameWithNoPlayersGameHasTwoPlayers()
        {
            _players.AddPlayer(new DummyPlayer("Test"));
            _players.Players().Should().Contain(p => p.Name == "Test");
        }

        [Fact]
        public void GameWithTwoPlayersCannotJoinThird()
        {
            _players.AddPlayer(new DummyPlayer("Test1"));
            _players.AddPlayer(new DummyPlayer("Test2"));
            _players.AddPlayer(new DummyPlayer("Test3"));
            _players.Players().Should().NotContain(p => p.Name == "Test3");
        }

        [Fact]
        public void GameWithSixPlayersContainsSix()
        {
            _players = new PokerPlayers(6);

            _players.AddPlayer(new DummyPlayer("Test1"));
            _players.AddPlayer(new DummyPlayer("Test2"));
            _players.AddPlayer(new DummyPlayer("Test3"));
            _players.AddPlayer(new DummyPlayer("Test4"));
            _players.AddPlayer(new DummyPlayer("Test5"));
            _players.AddPlayer(new DummyPlayer("Test6"));
            _players.Players().Should().HaveCount(6);
        }

        [Fact]
        public void AddAndRemovePlayerCountShouldBeZero()
        {
            _players.AddPlayer(new DummyPlayer("Test1"));
            _players.RemovePlayer(_players.Players().Take(1).First());
            _players.Players().Should().HaveCount(0);
        }

        private class DummyPlayer : Player
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

            public Player Create(string name)
            {
                return new DummyPlayer(name);
            }
        }
    }
}