using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static Func<T> ResolveStaticGetter<T>(this Type resourceType, string resourceName, bool includingNonPublic = true)
        {
            Debug.Assert(resourceType != null);
            Debug.Assert(!string.IsNullOrWhiteSpace(resourceName));

            try
            {
                return BuildStaticGetter<T>(resourceType, resourceName,includingNonPublic);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ToDo.CannotResolveStaticProperty(resourceType, resourceName, typeof(T)), ex);
            }
        }

        private static Func<T> BuildStaticGetter<T>(Type resourceType, string resourceName, bool includingNonPublic)
        {
            Debug.Assert(resourceType != null);
            Debug.Assert(!string.IsNullOrWhiteSpace(resourceName));

            var flags = BindingFlags.Static | BindingFlags.Public;
            if (includingNonPublic)
                flags = flags | BindingFlags.NonPublic;
            PropertyInfo property = resourceType.GetProperty(resourceName, flags);
            if (property == null)
                return null;
            var methodInfo = property.GetGetMethod(true);
            if (methodInfo == null)
                return null;
            var call = Expression.Call(methodInfo);
            return Expression.Lambda<Func<T>>(call).Compile();
        }
    }
}
