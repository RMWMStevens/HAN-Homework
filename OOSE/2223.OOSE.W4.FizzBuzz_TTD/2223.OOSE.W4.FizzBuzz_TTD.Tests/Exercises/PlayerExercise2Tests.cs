using OOSE.W4.FizzBuzz_TTD.Exercises;
using Xunit;

namespace OOSE.W4.FizzBuzz_TTD.Tests.Exercises
{
    public class PlayerExercise2Tests
    {
        readonly PlayerExercise2 sut;

        public PlayerExercise2Tests()
        {
            sut = new PlayerExercise2(new FakeNameGenerator2());
        }

        [Fact]
        public void AddRandomPlayer_Test()
        {
            // Arrange
            var name = "Roel";

            // Act
            sut.AddRandomPlayer();

            // Assert
            Assert.NotNull(sut.Players);
            Assert.Equal(name, sut.Players.Last().Name);
        }

        private class FakeNameGenerator2 : NameGenerator2
        {
            public override string GenerateRandomName() => "Roel";
        }
    }
}
