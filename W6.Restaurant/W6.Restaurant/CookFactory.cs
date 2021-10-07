using System;
using W6.Restaurant.Interfaces;

namespace W6.Restaurant
{
    public class CookFactory
    {
        string namespacePath = "W6.Restaurant.Implementations.";

        public ICook CreateCook(string cookType) => (ICook)Activator.CreateInstance(Type.GetType(namespacePath + cookType));
    }
}
