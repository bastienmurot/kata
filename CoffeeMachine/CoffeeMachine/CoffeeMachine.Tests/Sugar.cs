namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Money;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Sugar
    {
        private readonly DrinkBuilder _drinkBuilder;

        public Sugar()
        {
            _drinkBuilder = new DrinkBuilder(new SugarService(), new MoneyAmountService());
        }

        [Fact]
        public void GivenAddOneSugarShouldHaveOneSugarPlusStick()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Coffee());
            _drinkBuilder.AddSugar();

            // Act
            var result = _drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:1:0", result);
        }

        [Fact]
        public void GivenAddTwoSugarShouldHaveTwoSugarPlusStick()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Coffee());
            _drinkBuilder.AddSugar();
            _drinkBuilder.AddSugar();

            // Act
            var result = _drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:2:0", result);
        }
    }
}