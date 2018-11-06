namespace CoffeeMachine.Drink
{
    public class Chocolate : DrinkType
    {
        public override string GenerateOrder()
        {
            return "H";
        }

        public override string GetTextForUi()
        {
            return "chocolate";
        }
    }
}