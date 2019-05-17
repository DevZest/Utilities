using System;
using System.Collections.Generic;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static T VerifyNotNull<T>(this IReadOnlyList<T> list, int index, string paramName)
            where T : class
        {
            var reference = list[index];
            if (reference == null)
                throw new ArgumentNullException(string.Format("{0}[{1}]", paramName, index));
            return reference;
        }
    }
}
