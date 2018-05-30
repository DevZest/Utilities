using System;
using System.Reflection;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static MethodInfo GetStaticMethodInfo(this Type type, string methodName, bool includingNonPublic = true)
        {
            var flags = BindingFlags.Static | BindingFlags.Public;
            if (includingNonPublic)
                flags = flags | BindingFlags.NonPublic;
            return type.GetMethod(methodName, flags);
        }
    }
}
