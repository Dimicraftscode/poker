public interface Player
{
    string Name { get; }

    Player Create(string name);
}