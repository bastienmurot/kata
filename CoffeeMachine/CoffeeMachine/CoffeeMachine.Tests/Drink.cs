namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Drink
    {
        private readonly DrinkBuilder _drinkBuilder;

        public Drink()
        {
            _drinkBuilder = new DrinkBuilder(new SugarService());
        }

        [Fact]
        public void GivenChocolateActionShouldGenerateChocolateOrder()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Chocolate());

            // Act
            string result = _drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("H::", result);
        }

        [Fact]
        public void GivenTeaActionShouldGenerateTeaOrder()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Tea());

            // Act
            string result = _drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("T::", result);
        }

        [Fact]
        public void GivenCoffeeActionShouldGenerateCoffeeOrder()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Coffee());

            // Act
            string result = _drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("C::", result);
        }
    }
}