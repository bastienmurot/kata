namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Money;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Money
    {
        [Fact]
        public void GivenCorrectAmountForChocolateShouldIndicateAmountIsEnough()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService(), new MoneyAmountService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.InsertMoney(0.3);
            drinkBuilder.InsertMoney(0.2);

            // Act
            bool result = drinkBuilder.IsAmountIsEnough;

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GivenBadAmountForChocolateShouldIndicateAmountIsInsufficient()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService(), new MoneyAmountService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.InsertMoney(0.3);

            // Act
            bool result = drinkBuilder.IsAmountIsEnough;

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GivenBadAmountForChocolateShouldGetMissingAMountMessage()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService(), new MoneyAmountService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.InsertMoney(0.3);

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.False(drinkBuilder.IsAmountIsEnough);
            Assert.Equal("0,2€ missing", result);
        }
    }
}