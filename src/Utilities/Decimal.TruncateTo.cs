using System;

namespace DevZest
{
    internal static partial class Extensions
    {
        public static decimal TruncateTo(this decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}
