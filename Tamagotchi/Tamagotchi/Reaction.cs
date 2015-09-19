using System.Collections.Generic;
using Public_Interfaces;

namespace Tamagotchi
{

    internal interface IReaction<in T> where T : ITamagotchiInfluence
    {
        void React(T influential, ITamagotchiState currentState, out ITamagotchiState newState);
    }

    internal class Reaction<T> : IReaction<T> where T : ITamagotchiInfluence
    {
        private readonly IDictionary<T, IStateModifier> _modifiers;

        public Reaction(IDictionary<T, IStateModifier> modifiers)
        {
            _modifiers = modifiers;
        }

        public void React(T influential, ITamagotchiState currentState, out ITamagotchiState newState)
        {
            if (_modifiers.ContainsKey(influential))
            {
                newState = _modifiers[influential].Modify(currentState, influential.Coefficient);
                return;
            }
            //Todo: create random modifier
            newState = new TamagotchiState();
        }
    }
}