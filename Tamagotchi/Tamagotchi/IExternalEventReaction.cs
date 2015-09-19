using System.Collections.Generic;
using Public_Interfaces;

namespace Tamagotchi
{
    internal interface IExternalEventReaction : IReaction<IExternalEvent>
    {
    }

    internal class ExternalEventReaction : Reaction<IExternalEvent>, IExternalEventReaction
    {
        public ExternalEventReaction(IDictionary<IExternalEvent, IStateModifier> modifiers) : base(modifiers)
        {
        }
    }
}