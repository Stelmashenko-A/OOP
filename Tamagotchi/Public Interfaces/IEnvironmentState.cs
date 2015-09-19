namespace Public_Interfaces
{
    public interface IEnvironmentState : ITamagotchiInfluence
    {
        double Intensity { get; }
    }
}