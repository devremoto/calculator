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

        //[Theory]
        //[InlineData(10, 10, 20)]
        //[InlineData(1, 1, 2)]
        //[InlineData(-1, 10, 9)]
        //public void AddTest(int a, int b, int expected)
        //{
        //    // Act 
        //    var result = _calculator.Add(a, b);

        //    // Assert
        //    Assert.Equal(expected, result);
        //}

        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 10, -11)]
        public void SubtractTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 10, -10)]
        public void MultiplyTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]       
        [InlineData(1, 1, 1)]
        public void DivideTest(int a, int b, int expected)
        {
            // Act 
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}