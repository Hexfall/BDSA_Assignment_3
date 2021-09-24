using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) => throw new NotImplementedException();
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) => throw new NotImplementedException();
        public static bool IsSecure(this Uri uri) => throw new NotImplementedException();
        public static int WordCount(this string str) => throw new NotImplementedException();
    }
}
