using System;

namespace PowerPlantCodingChallenge.Services
{
    public static class Helper
    {
        public static T CreateInstance<T>(this Type type)
        {
            return (T)Activator.CreateInstance(type, new object[] { });
        }
    }
}
