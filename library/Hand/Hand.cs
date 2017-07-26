namespace Library
{
    public interface Hand
    {
        void Run();

        void CollectMoney();

        Action Next();
    }
}
