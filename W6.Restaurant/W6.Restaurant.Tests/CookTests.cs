using W6.Restaurant.Implementations;
using Xunit;

namespace W6.Restaurant.Tests
{
    public class CookTests
    {
        [Fact]
        public void HardRockCookTest()
        {
            // Arrange
            var cook = new HardRockCook();
            var expected = "Take a collection of knives and put some hard rockmusic on";

            // Act
            var result = cook.Prepare();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SimpleCookTest()
        {
            // Arrange
            var cook = new SimpleCook();
            var expected = "Put an apron on";

            // Act
            var result = cook.Prepare();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SoccerTest()
        {
            // Arrange
            var cook = new SoccerCook();
            var expected = "Open a beer and hum the anthem of their favourite soccer team";

            // Act
            var result = cook.Prepare();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
