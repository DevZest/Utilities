using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        private static class ToDo
        {
            public static string ArgumentIsNullOrWhitespace(string parameterName)
            {
                return string.Format("The argument '{0}' cannot be null, empty or contain only white space.", parameterName);
            }

            public static string ArgumentIsNullOrEmptyList(object parameterName)
            {
                return string.Format("The argument '{0}' cannot be null or empty.", parameterName);
            }

            public static string CannotResolveStaticProperty(Type resourceType, string resourceName, Type propertyType)
            {
                return string.Format("Cannot resolve static property {0}.{1} of {2}.", resourceType, resourceName, propertyType);
            }
        }
    }
}
