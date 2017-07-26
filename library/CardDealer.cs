using System;
using System.Collections.Generic;

namespace Library{
    public class CardDealer : Dealer
    {   
        public Card DealCard()
        {
            return new PlayingCard("2", "c");
        }

        private static Stack<Card> Deck()
        {
            return new Stack<Card>();
        }
    }
}