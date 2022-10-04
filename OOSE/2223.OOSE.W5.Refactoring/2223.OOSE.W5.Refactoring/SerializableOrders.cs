using Newtonsoft.Json;

namespace OOSE.W5.Refactoring
{
    public class SerializableOrders
    {
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        public SerializableOrders(List<Order> orders)
        {
            Orders = orders;
        }
    }
}
