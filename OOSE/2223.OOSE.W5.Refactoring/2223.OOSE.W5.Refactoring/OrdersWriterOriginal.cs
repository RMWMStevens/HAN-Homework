using System.Text;

namespace OOSE.W5.Refactoring
{
    public class OrdersWriterOriginal
    {
        public string Run(List<Order> orders)
        {
            var sb = new StringBuilder("{\"orders\": [");

            foreach (var order in orders)
            {
                sb.Append("{");
                sb.Append("\"id\": ");
                sb.Append(order.OrderId);
                sb.Append(", ");
                sb.Append("\"products\": [");

                foreach (var product in order.Products)
                {
                    sb.Append("{");
                    sb.Append("\"code\": \"");
                    sb.Append(product.Code);
                    sb.Append("\", ");
                    sb.Append("\"color\": \"");
                    sb.Append(GetColorFor(product));
                    sb.Append("\", ");

                    if (product.Size != -1)
                    {
                        sb.Append("\"size\": \"");
                        sb.Append(GetSizeFor(product));
                        sb.Append("\", ");
                    }

                    sb.Append("\"price\": ");
                    sb.Append(product.Price);
                    sb.Append(", ");
                    sb.Append("\"currency\": \"");
                    sb.Append(product.Currency);
                    sb.Append("\"} ");
                }

                if (order.Products.Count > 0)
                {
                    sb.Remove(sb.Length - 2, 1);
                }

                sb.Append("}, ");
            }

            if (orders.Count > 0)
            {
                sb.Remove(sb.Length - 2, 2);
            }

            sb.Append("]}");
            sb.Append("]}");
            return sb.ToString();
        }

        private string GetSizeFor(Product product)
        {
            switch (product.Size)
            {
                case 1:
                    return "XS";
                case 2:
                    return "S";
                case 3:
                    return "M";
                case 4:
                    return "L";
                case 5:
                    return "XL";
                case 6:
                    return "XXL";
                default:
                    return "Invalid size";
            }
        }

        private string GetColorFor(Product product)
        {
            switch (product.Color)
            {
                case 1:
                    return "blue";
                case 2:
                    return "red";
                case 3:
                    return "yellow";
                default:
                    return "no color";
            }
        }
    }
}
