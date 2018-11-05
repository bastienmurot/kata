namespace CoffeeMachine.Drink
{
    public class Coffee : ISelectableDrink
    {
        public string GenerateOrder()
        {
            return "C";
        }
    }
}