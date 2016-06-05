namespace OptimizedBindingBase.Extensions
{
    public static class ObjectExtensions
    {
        public static T OfType<T>(this object source)
        {
            if (source is T)
            {
                return (T)source;
            }

            return default(T);
        }
    }
}
