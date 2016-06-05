using System.Collections.Generic;
namespace OptimizedBindingBase.Extensions
{
    public static class GenericTypeExtensions
    {
        public static bool EqualityEquals<T>(this T obj1, T obj2)
        {
            return EqualityComparer<T>.Default.Equals(obj1, obj2);
        }
    }
}
