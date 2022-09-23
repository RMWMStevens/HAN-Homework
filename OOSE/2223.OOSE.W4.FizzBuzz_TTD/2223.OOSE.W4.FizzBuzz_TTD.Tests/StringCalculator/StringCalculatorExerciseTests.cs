using OOSE.W4.FizzBuzz_TTD.StringCalculator;
using Xunit;

namespace OOSE.W4.FizzBuzz_TTD.Tests.StringCalculator
{
    public class StringCalculatorExerciseTests
    {
        readonly StringCalculatorExercise sut = new();

        [Fact]
        public void Add_ShouldReturn0_WhenEmptyString()
        {
            Assert.Equal(0, sut.Add(""));
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void Add_ShouldReturnSum_ForTwoNumberInputs(string numbers, int expected)
        {
            Assert.Equal(expected, sut.Add(numbers));
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        public void Add_ShouldReturnSum_ForThreeNumberInputs(string numbers, int expected)
        {
            Assert.Equal(expected, sut.Add(numbers));
        }

        [Theory]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1,2,3,4,5,6", 21)]
        [InlineData("1,2,3,4,5,6,7", 28)]
        public void Add_ShouldReturnSum_ForVaryingAmountsOfNumberInputs(string numbers, int expected)
        {
            Assert.Equal(expected, sut.Add(numbers));
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        public void Add_ShouldReturnSum_ForNewLinesBetweenNumbers(string numbers, int expected)
        {
            Assert.Equal(expected, sut.Add(numbers));
        }

        [Fact]
        public void Add_ShoulThrowFormatException_ForIllegalSeparatorsInput()
        {
            Assert.Throws<FormatException>(() => sut.Add("1,\n"));
        }
    }
}
