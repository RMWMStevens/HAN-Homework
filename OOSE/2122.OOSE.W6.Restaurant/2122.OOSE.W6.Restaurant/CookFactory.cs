using OOSE.W6.Restaurant.Interfaces;
using System;

namespace OOSE.W6.Restaurant
{
    public class CookFactory
    {
        readonly string namespacePath = "OOSE.W6.Restaurant.Implementations.";

        public ICook CreateCook(string cookType) => (ICook)Activator.CreateInstance(Type.GetType(namespacePath + cookType));
    }
}
