namespace Functional_FooBarQix
{
    public static class FunctionalFooBarQixExtension
    {
        public static string AppendWhen(
            this string @this,
            string number,
            string specialNumber,
            string specialOutput) =>
                number.Contains(specialNumber) ? @this += specialOutput : number;
    }
}