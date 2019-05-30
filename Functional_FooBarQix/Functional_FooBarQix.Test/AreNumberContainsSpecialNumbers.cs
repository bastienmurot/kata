namespace Functional_FooBarQix.Test
{
    using Xunit;

    public class AreNumberContainsSpecialNumbers
    {
        [Fact]
        public void GivenANumberContainingThreeReturnFoo()
        {
            // Act
            string result = string.Empty.AppendWhen("13", "3", "Foo");

            // Assert
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GivenANumberContainingFiveReturnBar()
        {
            // Act
            string result = string.Empty.AppendWhen("15", "5", "Bar");

            // Assert
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void GivenANumberContainingSevenReturnQix()
        {
            // Act
            string result = string.Empty.AppendWhen("17", "7", "Qix");

            // Assert
            Assert.Equal("Qix", result);
        }

        [Fact]
        public void GivenANumberContainingThreeAndFiveReturnFooBar()
        {
            string number = "53";

            // Act
            string result = string.Empty
                .AppendWhen(number, "3", "Foo")
                .AppendWhen(number, "5", "Bar");

            // Assert
            Assert.Equal("FooBar", result);
        }
    }
}