namespace CoffeeMachine.Sugar
{
    using CoffeeMachine.Drink;

    public interface ISugarService : IMessageGenerator
    {
        void AddSugar();
    }
}