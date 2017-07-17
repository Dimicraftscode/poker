using System;
using System.Collections.Generic;
using System.Linq;

public class PokerPlayers : Players
{
    private List<Player> players;
    int _maxPlayers;
    public PokerPlayers(int max)
    {
        players = new List<Player>();
        _maxPlayers = max;
    }

    public void AddPlayer(Player player)
    {
        if (players.Count() < _maxPlayers)
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
