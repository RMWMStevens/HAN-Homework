using W4.FizzBuzz_TDD.Exercises;
using Xunit;

namespace W4.FizzBuzz_TDD.Tests.ExercisesTests
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
        [InlineData(15, "Fizz")]
        public void FizzTest(int number, string expected)
        {
            // Act
            var result = sut.Fizz(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "")]
        [InlineData(3, "")]
        [InlineData(4, "")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "Buzz")]
        public void BuzzTest(int number, string expected)
        {
            // Act
            var result = sut.Buzz(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzTest(int number, string expected)
        {
            // Act
            var result = sut.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
