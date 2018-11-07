namespace CoffeeMachine
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Money;
    using CoffeeMachine.Sugar;

    public class DrinkBuilder
    {
        private DrinkType _selectableDrink;
        private readonly ISugarService _sugarService;
        private readonly IMoneyAmountService _moneyAmountService;
        private double _missingAmount;

        public bool IsAmountIsEnough { get; private set; }

        public DrinkBuilder(ISugarService sugarService, IMoneyAmountService moneyAmountService)
        {
            _sugarService = sugarService;
            _moneyAmountService = moneyAmountService;
        }

        public void InsertMoney(double amount)
        {
            _moneyAmountService.AddMoney(amount);

            _missingAmount = _moneyAmountService.GetMissingAMount(_selectableDrink);

            IsAmountIsEnough = !(_missingAmount > 0);
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
            string message = string.Empty;

            if (!IsAmountIsEnough)
            {
                message = $"{_missingAmount}€ missing";
            }
            else
            {
                string drink = _selectableDrink.GetTextForUi();

                string sugar = _sugarService.GetTextForUi();

                message =  $"M:Drink maker makes 1 {drink} with {sugar}";
            }

            return message;
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