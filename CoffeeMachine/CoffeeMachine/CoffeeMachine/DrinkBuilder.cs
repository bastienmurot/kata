namespace CoffeeMachine
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Sugar;

    public class DrinkBuilder
    {
        private ISelectableDrink _selectableDrink;
        private readonly ISugarService _sugarService;

        private int _sugarCount = 0;

        public DrinkBuilder(ISugarService sugarService)
        {
            _sugarService = sugarService;
        }

        public void SelectDrink(ISelectableDrink selectedDrink)
        {
            _selectableDrink = selectedDrink;
        }

        public void AddSugar()
        {
            _sugarCount++;
        }

        public string SendMessageToUi()
        {
            return string.Empty;
        }

        public string GetOrder()
        {
            string order = string.Empty;

            order = _selectableDrink.GenerateOrder();

            order += _sugarService.GenerateOrder(_sugarCount);

            return order;
        }
    }
}