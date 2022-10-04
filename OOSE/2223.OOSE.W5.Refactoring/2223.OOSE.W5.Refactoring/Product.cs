using Newtonsoft.Json;

namespace OOSE.W5.Refactoring
{
    public class Product
    {
        [JsonProperty("size")]
        public int Size { get; init; }

        [JsonProperty("color")]
        public int Color { get; init; }

        [JsonProperty("code'")]
        public string Code { get; init; }

        [JsonProperty("price")]
        public decimal Price { get; init; }

        [JsonProperty("currency")]
        public string Currency { get; init; }
    }
}