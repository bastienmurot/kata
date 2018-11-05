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
        public void GivenAddOneSugarShouldHaveOneSugar()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();
            drinkBuilder.SelectDrink(new Coffee());
            drinkBuilder.AddSugar();

           // Act
           var result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:1:", result);
        }

        [Fact]
        public void GivenAddTwoSugarShouldHaveTwoSugar()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();
            drinkBuilder.SelectDrink(new Coffee());
            drinkBuilder.AddSugar();
            drinkBuilder.AddSugar();

            // Act
            var result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C:2:", result);
        }
    }
}