using Newtonsoft.Json;

namespace OOSE.W5.Refactoring.Tests
{
    public class OrdersWriterOriginalTests
    {
        readonly OrdersWriterOriginal sut = new();

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
            //var deserializedJson = JsonConvert.DeserializeObject<SerializableOrders>(result); // JSON validity check
            //Assert.Equal(orders.First().OrderId, deserializedJson.Orders.First().OrderId);
        }
    }
}