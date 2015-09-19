namespace Public_Interfaces
{
    public interface ITamagotchiState
    {
        int Health { get; }

        int Happiness { get; }

        int Energy { get; }

        bool IsDead { get; }
    }
}