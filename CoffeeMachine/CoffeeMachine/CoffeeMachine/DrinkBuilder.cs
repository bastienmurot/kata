using System;

namespace CoffeeMachine
{
    public class DrinkBuilder
    {
        private DrinkType _drinkType;

        public void AddChocolate()
        {
            _drinkType = DrinkType.Chocolate;
        }

        public void AddTea()
        {
            _drinkType = DrinkType.Tea;
        }

        public void AddCoffee()
        {
            _drinkType = DrinkType.Coffee;
        }

        public string GetOrder()
        {
            string order = string.Empty;

            switch(_drinkType)
            {
                case DrinkType.Chocolate:
                    order += "H";
                    break;
                case DrinkType.Tea:
                    order += "T";
                    break;
                case DrinkType.Coffee:
                    order += "C";
                    break;
            }

            order += "::";

            return order;
        }
    }
}