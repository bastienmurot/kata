namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using Xunit;

    public class TestCoffeeMachine
    {
        private readonly DrinkBuilder _drinkBuilder;

        public TestCoffeeMachine()
        {
            _drinkBuilder = new DrinkBuilder();
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