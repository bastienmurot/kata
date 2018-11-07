namespace CoffeeMachine.Drink
{
    public class Tea : DrinkType
    {
        public override string GenerateOrder()
        {
            return "T";
        }

        public override string GetTextForUi()
        {
            return "tea";
        }

        public override double Price => 0.4;
    }
}