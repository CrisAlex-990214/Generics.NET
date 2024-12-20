namespace Generics.NET
{
    public static class Helper<T> where T : class, ICommonEntity
    {
        public static bool Matches<V>(T item, V value)
        {
            return item.Name.Equals(value);
        }

        //public static bool Matches(string value1, string value2)
        //{
        //    return value1.Equals(value2);
        //}

        //public static bool Matches(decimal value1, decimal value2)
        //{
        //    return value1.Equals(value2);
        //}
    }
}
