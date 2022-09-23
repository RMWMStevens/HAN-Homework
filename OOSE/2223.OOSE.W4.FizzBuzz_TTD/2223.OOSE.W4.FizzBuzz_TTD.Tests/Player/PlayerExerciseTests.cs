using Moq;
using OOSE.W4.FizzBuzz_TTD.Player;
using Xunit;

namespace OOSE.W4.FizzBuzz_TTD.Tests.Player
{
    public class PlayerExerciseTests
    {
        readonly Mock<INameGenerator> nameGenerator;
        readonly PlayerExercise sut;

        public PlayerExerciseTests()
        {
            nameGenerator = new Mock<INameGenerator>();
            sut = new PlayerExercise(nameGenerator.Object);
        }

        [Fact]
        public void AddRandomPlayer_Test()
        {
            // Arrange
            var name = "Roel";
            nameGenerator
                .Setup(_ => _.GenerateRandomName())
                .Returns(name);

            // Act
            sut.AddRandomPlayer();

            // Assert
            Assert.NotNull(sut.Players);
            Assert.Equal(name, sut.Players.Last().Name);
        }
    }
}
