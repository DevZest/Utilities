using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        internal static T VerifyNotNull<T>(T value, string parameterName)
            where T : class
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);

            return value;
        }

    }
}
