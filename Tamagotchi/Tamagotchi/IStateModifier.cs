using System;
using Public_Interfaces;

namespace Tamagotchi
{
    internal interface IStateModifier
    {
        ITamagotchiState Modify(ITamagotchiState state, double coefficient = 1);
    }

    internal class StateModifier : IStateModifier
    {
        private readonly Func<int, int> _healthModifier;
        private readonly Func<int, int> _happinessModifier;
        private readonly Func<int, int> _energyModifier;

        public StateModifier(Func<int, int> healthModifier, Func<int, int> happinessModifier, Func<int, int> energyModifier)
        {
            _healthModifier = healthModifier;
            _happinessModifier = happinessModifier;
            _energyModifier = energyModifier;
        }

        public ITamagotchiState Modify(ITamagotchiState state, double coefficient = 1)
        {
            var newState = new InternalTamagotchiState();
            newState.SetHealth(state.Health - (int) (coefficient*_healthModifier.Invoke(state.Health)));
            newState.SetHappiness(state.Happiness - (int)(coefficient * _happinessModifier.Invoke(state.Happiness)));
            newState.SetEnergy(state.Energy - (int)(coefficient * _energyModifier.Invoke(state.Energy)));
            return newState;
        }

        private class InternalTamagotchiState : TamagotchiState
        {
            internal InternalTamagotchiState()
            {
                Health = 100;
                Happiness = 100;
                Energy = 100;
            }

            public void SetHealth(int health)
            {
                Health = health;
            }

            public void SetHappiness(int happiness)
            {
                Happiness = happiness;
            }

            public void SetEnergy(int energy)
            {
                Energy = energy;
            }
        }
    }

}