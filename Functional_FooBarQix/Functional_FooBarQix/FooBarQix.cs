namespace Functional_FooBarQix
{
    public class FooBarQix
    {
        public string Compute(string number)
        {
            string result = string.Empty;

            int numberToCheck = int.Parse(number);

            result = AreNumbersSpecialDivisible(result, numberToCheck);

            result = AreNumberContainsSpecialNumbers(result, number);

            return result == string.Empty ? number : result;
        }

        private static string AreNumberContainsSpecialNumbers(string result, string number)
        {
            if (number.Contains("3"))
            {
                result += "Foo";
            }

            if (number.Contains("5"))
            {
                result += "Bar";
            }

            if (number.Contains("7"))
            {
                result += "Qix";
            }

            return result;
        }

        private static string AreNumbersSpecialDivisible(string result, int numberToCheck)
        {
            if (numberToCheck % 3 == 0)
            {
                result += "Foo";
            }

            if (numberToCheck % 5 == 0)
            {
                result += "Bar";
            }

            if (numberToCheck % 7 == 0)
            {
                result += "Qix";
            }

            return result;
        }
    }
}