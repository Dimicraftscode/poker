using System;
using FluentAssertions;
using Xunit;

namespace TestApp
{
    public class PlayersShould
    {
        private PokerPlayers players;

        public PlayersShould()
        {
            players = new PokerPlayers(2);
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

        [Fact]
        public void GameWithSixPlayersContainsSix()
        {
            players = new PokerPlayers(6);

            players.AddPlayer(new DummyPlayer("Test1"));
            players.AddPlayer(new DummyPlayer("Test2"));
            players.AddPlayer(new DummyPlayer("Test3"));
            players.AddPlayer(new DummyPlayer("Test4"));
            players.AddPlayer(new DummyPlayer("Test5"));
            players.AddPlayer(new DummyPlayer("Test6"));
            players.Players().Should().HaveCount(6);
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