using OOSE.W6.Restaurant.Interfaces;
using System;

namespace OOSE.W6.Restaurant
{
    public class CookFactory
    {
        public ICook CreateCook(string cookType)
            => (ICook)Activator.CreateInstance(Type.GetType("OOSE.W6.Restaurant.Implementations." + cookType));
    }
}
