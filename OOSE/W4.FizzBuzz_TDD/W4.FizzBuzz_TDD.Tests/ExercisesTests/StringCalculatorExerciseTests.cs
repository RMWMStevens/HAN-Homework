using W4.FizzBuzz_TDD.Exercises;
using System;
using Xunit;

namespace W4.FizzBuzz_TDD.Tests.ExercisesTests
{
    public class StringCalculatorExerciseTests
    {
        readonly StringCalculatorExercise sut = new();

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,3", 6)]
        [InlineData("1\n2,3", 6)]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//|\n1|2", 3)]
        public void AddTest(string numberString, int expected)
        {
            // Act
            var result = sut.Add(numberString);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10,-10,10")]
        public void AddInvalidOperationExceptionTest(string numberString)
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sut.Add(numberString));
        }
    }
}
