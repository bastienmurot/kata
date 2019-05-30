namespace Functional_FooBarQix
{
    public class FooBarQix
    {
        public string Compute(string number)
        {
            string result = string.Empty;

            int numberToCheck = int.Parse(number);

            result = AreNumbersSpecialDivisible(result, numberToCheck);

            return result == string.Empty ? number : result;
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