using System.Collections.Generic;

public interface Players
{
    IEnumerable<Player> Players();
    void AddPlayer(Player player);
    void RemovePlayer(Player player);
}