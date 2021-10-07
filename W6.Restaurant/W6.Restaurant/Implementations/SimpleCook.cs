using W6.Restaurant.Interfaces;

namespace W6.Restaurant.Implementations
{
    public class SimpleCook : ICook
    {
        public string Prepare() => "Put an apron on";
    }
}
