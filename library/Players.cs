using System;
using System.Collections.Generic;
using Library;

public interface Players
{
    IEnumerable<Player> Players();
    void AddPlayer(Player player);
    void RemovePlayer(Player player);
    void All(Action<Player> pred);
}