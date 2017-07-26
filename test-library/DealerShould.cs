using FluentAssertions;
using Library;
using Xunit;

namespace TestApp
{
    public class DealerShould
    {
        [Fact]
        public void Exist()
        {
            var dealer = new CardDealer();
            dealer.Should().NotBeNull();
        }

    }
}