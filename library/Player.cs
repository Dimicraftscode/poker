using Library;

public interface Player
{
    string Name { get; }

    Player Create(string name);
    void AddCard(Card card);
    Card ShowCard();
}