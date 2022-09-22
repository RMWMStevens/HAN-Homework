using OOSE.W4.FizzBuzz_TTD.Exercises;
using Xunit;

namespace OOSE.W4.FizzBuzz_TTD.Tests.Exercises
{
    public class FizzBuzzExerciseTests
    {
        readonly FizzBuzzExercise sut = new();

        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "")]
        [InlineData(5, "")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "")]
        [InlineData(12, "Fizz")]
        [InlineData(15, "Fizz")]
        public void Fizz_Test(int number, string expectedLine)
        {
            // Act
            var line = sut.Fizz(number);

            // Assert
            Assert.Equal(expectedLine, line);
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "")]
        [InlineData(3, "")]
        [InlineData(4, "")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "")]
        [InlineData(10, "Buzz")]
        [InlineData(12, "")]
        [InlineData(15, "Buzz")]
        public void Buzz_Test(int number, string expectedLine)
        {
            // Act
            var line = sut.Buzz(number);

            // Assert
            Assert.Equal(expectedLine, line);
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(12, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        public void GetLineForNumber_Test(int number, string expectedLine)
        {
            // Act
            var line = sut.GetLineForNumber(number);

            // Assert
            Assert.Equal(expectedLine, line);
        }
    }
}
