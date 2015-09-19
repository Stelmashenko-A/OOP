using System.Collections.Generic;
using Public_Interfaces;

namespace Tamagotchi
{
    internal interface IFoodReaction : IReaction<IFood>
    {
    }

    internal class FoodReaction : Reaction<IFood>, IFoodReaction
    {
        public FoodReaction(IDictionary<IFood, IStateModifier> modifiers) : base(modifiers)
        {
        }
    }
}