using System;

public class PokerPlayer : Player
{
    private readonly string name;

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
}