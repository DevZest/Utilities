using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static string VerifyNotEmpty(this string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(Stubs.ArgumentIsNullOrWhitespace(parameterName), parameterName);

            return value;
        }
    }
}
