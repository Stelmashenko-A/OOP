using System.Collections.Generic;
using Public_Interfaces;

namespace Tamagotchi
{
    internal interface IEnvironmentStateReaction : IReaction<IEnvironmentState>
    {
    }

    internal class EnvironmentStateReaction : Reaction<IEnvironmentState>, IEnvironmentStateReaction
    {
        public EnvironmentStateReaction(IDictionary<IEnvironmentState, IStateModifier> modifiers) : base(modifiers)
        {
        }
    }
}