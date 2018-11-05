namespace CoffeeMachine.Drink
{
    public class Tea : ISelectableDrink
    {
        public string GenerateOrder()
        {
            return "T";
        }
    }
}