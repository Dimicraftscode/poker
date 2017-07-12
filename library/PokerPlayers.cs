using System;
using System.Collections.Generic;
using System.Linq;

public class PokerPlayers : Players
{
    private List<Player> players;
    int maxPlayers;
    public PokerPlayers()
    {
        players = new List<Player>();
        maxPlayers = 2;
    }

    public void AddPlayer(Player player)
    {
        if (players.Count() < maxPlayers)
        {
            players.Add(player);
        }
    }

    public IEnumerable<Player> Players()
    {
        return players;
    }

    public void RemovePlayer(Player player)
    {
        players.Remove(player);
    }
}
