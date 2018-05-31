using System.Collections.Generic;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static IReadOnlyList<T> VerifyNoNullItem<T>(this IReadOnlyList<T> list, string listParamName)
            where T : class
        {
            if (list == null)
                return list;

            for (int i = 0; i < list.Count; i++)
                list.VerifyNotNull(i, listParamName);

            return list;
        }

    }
}
