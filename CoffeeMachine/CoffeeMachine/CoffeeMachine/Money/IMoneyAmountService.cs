namespace CoffeeMachine.Money
{
    using CoffeeMachine.Drink;

    public interface IMoneyAmountService
    {
        double GetMissingAMount(DrinkType drinkType);

        void AddMoney(double money);
    }
}