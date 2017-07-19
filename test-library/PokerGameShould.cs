using Library;
using Xunit;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using FluentAssertions;
using System;
using Moq;

namespace TestApp
{
    public class PokergameShould
    {
        private Game _game;
        public PokergameShould()
        {
            var players = new Mock<Players>();
            _game = new Pokergame(players.Object);
        }

        [Fact]
        public void TestGame()
        {
            _game.Should().NotBeNull();
        }

        
    }
}