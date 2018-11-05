namespace CoffeeMachine.Drink
{
    public class Chocolate : ISelectableDrink
    {
        public string GenerateOrder()
        {
            return "H";
        }
    }
}