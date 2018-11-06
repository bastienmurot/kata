namespace CoffeeMachine.Drink
{
    public abstract class DrinkType : IMessageGenerator
    {
        public abstract string GenerateOrder();

        public abstract string GetTextForUi();
    }
}