namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Money
    {
        [Fact]
        public void ItHasMethod()
        {
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Chocolate());

            drinkBuilder.InsertMoney(0.5);
        }

        [Fact]
        public void GivenCorrectAmountForChocolateShouldReturnChocolateOrder()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.InsertMoney(0.5);

            // Act
            string result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("H::", result);
        }
    }
}