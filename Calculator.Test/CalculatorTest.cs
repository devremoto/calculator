using Xunit;

namespace Calculator.Test
{
    public class CalculatorTest
    {
        private Operations _calculator;

        public CalculatorTest()
        {
            _calculator = new Operations();
        }

        [Theory]
        [InlineData(10, 2, 12)]
        public void AddTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        public void SubtractTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        public void MultiplyTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivideTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}