using System;
using Library;

public class PokerPlayer : Player
{
    private readonly string name;
    private Card _card;

    public PokerPlayer(string name)
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

    public Player Create(string name)
    {
        return new PokerPlayer(name);
    }

    public void AddCard(Card card){
        _card = card;
    }

    public Card ShowCard()
    {
        return _card;
    }
}