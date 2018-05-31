using System;
using System.Collections.Generic;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static IReadOnlyList<T> VerifyNotEmpty<T>(this IReadOnlyList<T> list, string parameterName)
        {
            list.VerifyNotNull(parameterName);
            if (list.Count == 0)
                throw new ArgumentException(ToDo.ArgumentIsNullOrEmptyList(parameterName), parameterName);

            return list;
        }
    }
}
