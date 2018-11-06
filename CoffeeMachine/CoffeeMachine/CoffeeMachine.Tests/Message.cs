namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Message
    {
        [Fact]
        public void GivenChocolateSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Chocolate());

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenTeaSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Tea());

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 tea with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenCoffeeSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Coffee());

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 coffee with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenChocolateSelectionWithOneSugarShouldGenerateMessageToUI()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.AddSugar();

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with 1 sugar and a stick", result);
        }

        [Fact]
        public void GivenChocolateSelectionWithTwoSugarShouldGenerateMessageToUI()
        {
            // Arrange
            var drinkBuilder = new DrinkBuilder(new SugarService());
            drinkBuilder.SelectDrink(new Chocolate());
            drinkBuilder.AddSugar();
            drinkBuilder.AddSugar();

            // Act
            string result = drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with 2 sugars and a stick", result);
        }
    }
}