namespace CoffeeMachine.Tests
{
    using CoffeeMachine.Drink;
    using CoffeeMachine.Money;
    using CoffeeMachine.Sugar;
    using Xunit;

    public class Message
    {
        private readonly DrinkBuilder _drinkBuilder;

        public Message()
        {
            _drinkBuilder = new DrinkBuilder(new SugarService(), new MoneyAmountService());
        }
 
        [Fact]
        public void GivenChocolateSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Chocolate());
            _drinkBuilder.InsertMoney(0.5);

            // Act
            string result = _drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenTeaSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Tea());
            _drinkBuilder.InsertMoney(0.4);

            // Act
            string result = _drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 tea with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenCoffeeSelectionShouldGenerateMessageToUI()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Coffee());
            _drinkBuilder.InsertMoney(0.6);

            // Act
            string result = _drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 coffee with no sugar and therefore no stick", result);
        }

        [Fact]
        public void GivenChocolateSelectionWithOneSugarShouldGenerateMessageToUI()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Chocolate());
            _drinkBuilder.AddSugar();
            _drinkBuilder.InsertMoney(0.5);

            // Act
            string result = _drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with 1 sugar and a stick", result);
        }

        [Fact]
        public void GivenChocolateSelectionWithTwoSugarShouldGenerateMessageToUI()
        {
            // Arrange
            _drinkBuilder.SelectDrink(new Chocolate());
            _drinkBuilder.AddSugar();
            _drinkBuilder.AddSugar();
            _drinkBuilder.InsertMoney(0.5);

            // Act
            string result = _drinkBuilder.SendMessageToUi();

            // Assert
            Assert.Equal("M:Drink maker makes 1 chocolate with 2 sugars and a stick", result);
        }
    }
}