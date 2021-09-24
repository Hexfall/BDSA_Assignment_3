using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) => items.Aggregate((IEnumerable<T>)new List<T>(), (agg, item) => agg.Concat(item));
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) => items.Where(o => predicate(o));
        public static bool IsSecure(this Uri uri) => uri.AbsoluteUri.ToLower().StartsWith("https");
        public static int WordCount(this string str) => throw new NotImplementedException();
    }
}
