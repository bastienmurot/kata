using System;
using CoffeeMachine.Drink;

namespace CoffeeMachine
{
    public class DrinkBuilder
    {
        private ISelectableDrink _selectableDrink;

        public void SelectDrink(ISelectableDrink selectedDrink)
        {
            _selectableDrink = selectedDrink;
        }

        public void AddSugar()
        {
        }

        public string GetOrder()
        {
            string order = string.Empty;

            order = _selectableDrink.GenerateOrder() + "::";

            return order;
        }
    }
}