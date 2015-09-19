using Public_Interfaces;

namespace Tamagotchi
{
   
    internal class TamagotchiState : ITamagotchiState
    {
        public int Health { get; protected set; }
        public int Happiness { get; protected set; }
        public int Energy { get; protected set; }
        public bool IsDead => Health == 0 || Happiness == 0 || Energy == 0;

        internal TamagotchiState()
        {
            Health = 100;
            Happiness = 100;
            Energy = 100;
        }
    
    }
}
