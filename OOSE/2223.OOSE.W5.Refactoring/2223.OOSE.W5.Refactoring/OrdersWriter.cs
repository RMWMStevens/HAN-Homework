using Newtonsoft.Json;

namespace OOSE.W5.Refactoring
{
    public class OrdersWriter
    {
        public string Run(List<Order> orders)
        {
            return JsonConvert.SerializeObject(
                new SerializableOrders(orders));
        }
    }
}
