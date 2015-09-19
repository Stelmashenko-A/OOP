namespace Public_Interfaces
{
    public interface ITamagotchiState
    {
        double Health { get; }

        double Happiness { get; }

        bool IsDead { get; }
    }
}