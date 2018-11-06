namespace CoffeeMachine.Sugar
{
    public class SugarService : ISugarService
    {
        private int _sugarCount = 0;

        public void AddSugar()
        {
            _sugarCount++;
        }

        public string GenerateOrder()
        {
            return _sugarCount > 0 ? ":" + _sugarCount + ":0" : "::";
        }

        public string GetTextForUi()
        {
            string text = string.Empty;

            if (_sugarCount == 0)
            {
                text = "no sugar and therefore no stick";
            }
            else
            {
                string pluralOrNot = _sugarCount == 1 ? string.Empty : "s";

                text = $"{_sugarCount} sugar{pluralOrNot} and a stick";
            }
            return text;
        }
    }
}