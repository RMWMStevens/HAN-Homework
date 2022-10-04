using Newtonsoft.Json;

namespace OOSE.W5.Refactoring
{
    public class Order
    {
        [JsonProperty("id")]
        public string OrderId { get; init; }

        [JsonProperty("products")]
        public List<Product> Products { get; init; }
    }
}