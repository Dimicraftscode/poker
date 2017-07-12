using System;
using FluentAssertions;
using Xunit;

namespace TestApp
{
    public class PlayerShould
    {
        private PokerPlayers players;

        public PlayerShould()
        {
            players = new PokerPlayers();
        }

        [Fact]
        public void PlayersCanBeCreated()
        {
            players.Should().NotBeNull();
        }

        [Fact]
        public void NewgameHasNoPlayers()
        {
            players.Players().Should().HaveCount(0);
        }

        [Fact]
        public void PlayerJoinsGameWithNoPlayersGameHasTwoPlayers()
        {
            players.AddPlayer(new DummyPlayer("Test"));
            players.Players().Should().Contain(p => p.Name == "Test");
        }

        [Fact]
        public void GameWithTwoPlayersCannotJoinThird()
        {
            players.AddPlayer(new DummyPlayer("Test1"));
            players.AddPlayer(new DummyPlayer("Test2"));
            players.AddPlayer(new DummyPlayer("Test3"));
            players.Players().Should().NotContain(p => p.Name == "Test3");
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
        }
    }
}