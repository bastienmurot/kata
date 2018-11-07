namespace CoffeeMachine.Money
{
    using CoffeeMachine.Drink;

    public class MoneyAmountService : IMoneyAmountService
    {
        private double _amount;

        public void AddMoney(double money)
        {
            _amount += money;
        }

        public double GetMissingAMount(DrinkType drinkType)
        {
            return drinkType.Price - _amount;
        }
    }
}