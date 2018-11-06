namespace CoffeeMachine.Sugar
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SugarService : ISugarService
    {
        public string GenerateOrder(int sugarCount)
        {
            return sugarCount > 0 ? ":" + sugarCount + ":0" : "::";
        }
    }
}