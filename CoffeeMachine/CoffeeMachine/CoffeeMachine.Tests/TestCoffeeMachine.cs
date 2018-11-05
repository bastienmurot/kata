namespace CoffeeMachine.Tests
{
    using Xunit;

    public class TestCoffeeMachine
    {
        [Fact]
        public void ItExists()
        {
            var drinkBuilder = new DrinkBuilder();
        }

        [Fact]
        public void GivenChocolateActionShouldGenerateChocolateOrder()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder();
            drinkBuilder.AddChocolate();

            // Act
            string result = drinkBuilder.GetOrder();

            // Assert
            Assert.Equal("H::", result);
        }
    }
}