namespace CoffeeMachine
{
    using CoffeeMachine.Drink;

    public class DrinkBuilder
    {
        private ISelectableDrink _selectableDrink;
        private int _sugarCount = 0;

        public void SelectDrink(ISelectableDrink selectedDrink)
        {
            _selectableDrink = selectedDrink;
        }

        public void AddSugar()
        {
            _sugarCount++;
        }

        public string GetOrder()
        {
            string order = string.Empty;

            order = _selectableDrink.GenerateOrder();

            order += _sugarCount > 0 ? ":" + _sugarCount + ":0" : "::";

            return order;
        }
    }
}