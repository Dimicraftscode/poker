using Library;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace TestApp
{
    public class PokergameShould
    {
        private Pokergame game;
        public PokergameShould()
        {
            game = new Pokergame();
        }

        [Fact]
        public void TestGame()
        {
            game.Should().NotBeNull();
        }

        
    }
}