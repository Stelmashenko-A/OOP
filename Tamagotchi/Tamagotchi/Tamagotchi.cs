using Public_Interfaces;

namespace Tamagotchi
{
    public class Tamagotchi : ITamagotchi
    {
        public ITamagotchiState State { get; private set; }

        private readonly IFoodReaction _foodReaction;

        private readonly IExternalEventReaction _externalEventReaction;

        private readonly IEnvironmentStateReaction _environmentStateReaction;

        internal Tamagotchi(IFoodReaction foodReaction, IExternalEventReaction externalEventReaction,
            IEnvironmentStateReaction environmentStateReaction)
        {
            _foodReaction = foodReaction;
            _externalEventReaction = externalEventReaction;
            _environmentStateReaction = environmentStateReaction;
        }

        public void PushFood(IFood food)
        {
            ITamagotchiState tamagotchiState;
            _foodReaction.React(food, State, out tamagotchiState);
            State = tamagotchiState;
        }

        public void ReactOnEvent(IExternalEvent externalEvent)
        {
            ITamagotchiState tamagotchiState;
            _externalEventReaction.React(externalEvent, State, out tamagotchiState);
            State = tamagotchiState;
        }

        public void ReactOnEnvironment(IEnvironmentState environment)
        {
            ITamagotchiState tamagotchiState;
            _environmentStateReaction.React(environment, State, out tamagotchiState);
            State = tamagotchiState;
        }
    }
}
