namespace OOSE.W5.Refactoring.Tests
{
    public class OrdersWriterTests
    {
        readonly OrdersWriter sut = new();

        [Fact]
        public void Run_Test()
        {
            // Arrange
            var orders = new List<Order>()
            {
                new Order()
                {
                    OrderId = "1",
                    Products = new()
                    {
                        new Product()
                        {
                            Size = 1,
                            Code = "1",
                            Color = 1,
                            Price = 12.00m,
                            Currency = "EUR"
                        }
                    }
                }
            };

            // Act
            var result = sut.Run(orders);

            // Assert
            Assert.NotNull(result);
        }
    }
}
