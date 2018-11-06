﻿namespace CoffeeMachine.Drink
{
    public class Coffee : DrinkType
    {
        public override string GenerateOrder()
        {
            return "C";
        }

        public override string GetTextForUi()
        {
            return "coffee";
        }
    }
}