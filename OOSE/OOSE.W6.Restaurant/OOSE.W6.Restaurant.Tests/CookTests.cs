using Xunit;

namespace OOSE.W6.Restaurant.Tests
{
    public class CookTests
    {
        readonly CookFactory cookFactory = new();

        [Theory]
        [InlineData("HardRockCook", "Take a collection of knives and put some hardrock music on")]
        [InlineData("SimpleCook", "Put an apron on")]
        [InlineData("SoccerCook", "Open a beer and hum the anthem of their favourite soccer team")]
        public void CookTest(string cookTypeName, string expected)
        {
            // Arrange
            var cook = cookFactory.CreateCook(cookTypeName);

            // Act
            var result = cook.Prepare();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
