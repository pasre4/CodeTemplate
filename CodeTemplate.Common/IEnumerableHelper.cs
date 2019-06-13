using System.Linq;

namespace System.Collections.Generic
{
    public static class IEnumerableHelper
    {
        public static bool IsAny<T>(this IEnumerable<T> lst)
        {
            return lst != null && lst.Any();
        }
    }
}