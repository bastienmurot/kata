namespace CoffeeMachine
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Sugar;

    public class DrinkBuilder
    {
        private DrinkType _selectableDrink;
        private readonly ISugarService _sugarService;

        public DrinkBuilder(ISugarService sugarService)
        {
            _sugarService = sugarService;
        }

        public void SelectDrink(DrinkType selectedDrink)
        {
            _selectableDrink = selectedDrink;
        }

        public void AddSugar()
        {
            _sugarService.AddSugar();
        }

        public string SendMessageToUi()
        {
            string drink = _selectableDrink.GetTextForUi();

            string sugar = _sugarService.GetTextForUi();

            return $"M:Drink maker makes 1 {drink} with {sugar}";
        }

        public string GetOrder()
        {
            string order = string.Empty;

            order = _selectableDrink.GenerateOrder();

            order += _sugarService.GenerateOrder();

            return order;
        }
    }
}