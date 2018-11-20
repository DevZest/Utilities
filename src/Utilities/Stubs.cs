using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        private static class Stubs
        {
            public static string ArgumentIsNullOrWhitespace(string parameterName)
            {
                return string.Format("The argument '{0}' cannot be null, empty or contain only white space.", parameterName);
            }

            public static string ArgumentIsNullOrEmptyList(object parameterName)
            {
                return string.Format("The argument '{0}' cannot be null or empty.", parameterName);
            }

            public static string FailedToResolveStaticProperty(Type type, string propertyName, Type propertyType)
            {
                return string.Format("Cannot resolve static property {0}.{1} of {2}.", type, propertyName, propertyType);
            }
        }
    }
}
