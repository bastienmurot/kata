namespace CoffeeMachine.Tests
{
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
    }
}