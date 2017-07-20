using FluentAssertions;
using Library;
using Moq;
using Xunit;
using System.Linq;

namespace TestApp
{
    public class DealCardsShould
    {
        [Fact]
        public void BeInstantiated()
        {
            var dealCards = new DealCards();
            dealCards.Should().NotBeNull();
        }

        [Fact]
        public void DealACardToEveryOne()
        {
            var players = new Mock<Players>();
            //create some cardcount output on playersMock
            var dealCards = new DealCards();
            //make sure this deals one card to every player
            dealCards.Act();
            //check players have card to be all one
        }
    }
}