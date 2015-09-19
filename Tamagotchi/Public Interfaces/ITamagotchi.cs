namespace Public_Interfaces
{
    public interface ITamagotchi
    {
        ITamagotchiState State { get; }

        void PushFood(IFood food);

        void ReactOnEvent(IExternalEvent externalEvent);

        void ReactOnEnvironment(IEnvironmentState environment);
    }
}