using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static bool IsComparable(this Type type)
        {
            return typeof(IComparable).IsAssignableFrom(type);
        }
    }
}
