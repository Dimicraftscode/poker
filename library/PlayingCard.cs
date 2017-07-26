namespace Library
{
    public class PlayingCard : Card
    {
        private readonly string _suit;
        private readonly string _value;
        public PlayingCard(string value, string suit)
        {
            _suit = suit;
            _value = value;
        }

        public override string ToString()
        {
            return $"{_value}{_suit}";
        }
    }
}