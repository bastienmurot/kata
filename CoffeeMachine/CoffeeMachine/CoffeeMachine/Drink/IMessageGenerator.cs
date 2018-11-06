namespace CoffeeMachine.Drink
{
    public interface IMessageGenerator
    {
        string GenerateOrder();

        string GetTextForUi();
    }
}