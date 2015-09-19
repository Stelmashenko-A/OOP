using System.Collections.Generic;

namespace Public_Interfaces
{
    public interface IEnvironment
    {
        void AddTamagotchi(ITamagotchi tamagotchi);

        void Tick();

        ///Tamagotchis whith their lifeTime 
        IList<KeyValuePair<ITamagotchi, int>> DeadTamagotchis();
    }
}