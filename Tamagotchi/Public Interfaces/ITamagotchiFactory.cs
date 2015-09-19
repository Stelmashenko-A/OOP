namespace Public_Interfaces
{
    public interface ITamagotchiFactory
    {
        ITamagotchi GetNext();

        void AddSample(ITamagotchi tamagotchi, int liveTime);
    }
}
