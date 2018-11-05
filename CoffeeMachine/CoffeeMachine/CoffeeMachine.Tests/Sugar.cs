namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using Xunit;

    public class Sugar
    {
        [Fact]
        public void ItHasMethod()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();

            // Act & Assert
            drinkBuilder.AddSugar();
        }

        [Fact]
        public void GivenAddOneSugarShouldHaveOneSugarPlusStick()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();
            drinkBuilder.SelectDrink(new Coffee());
            drinkBuilder.AddSugar();

            // Act
            var result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:1:0", result);
        }

        [Fact]
        public void GivenAddTwoSugarShouldHaveTwoSugarPlusStick()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();
            drinkBuilder.SelectDrink(new Coffee());
            drinkBuilder.AddSugar();
            drinkBuilder.AddSugar();

            // Act
            var result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:2:0", result);
        }
    }
}