using System;
using System.Reflection;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static bool IsNullable(this Type type)
        {
            return !type.GetTypeInfo().IsValueType || (Nullable.GetUnderlyingType(type) != null);
        }
    }
}
