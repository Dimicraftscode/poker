using FluentAssertions;
using Library;
using Moq;
using Xunit;
using System.Linq;

namespace TestApp
{
    public class DealOneCardShould
    {
        [Fact]
        public void BeInstantiated()
        {
            var dealer = new Mock<Dealer>();
            var dealCards = new DealOneCard(dealer.Object);
            dealCards.Should().NotBeNull();
        }

        [Fact]
        public void DealOneCardToEveryOne()
        {
            var players = new Mock<Players>();
            var dealer = new Mock<Dealer>();
            //create some cardcount output on playersMock
            var dealCards = new DealOneCard(dealer.Object);
            //make sure this deals one card to every player
            dealCards.Act();
            //check players have card to be all one
        }
    }
}