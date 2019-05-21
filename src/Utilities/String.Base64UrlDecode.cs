using System;
using System.Text;

namespace DevZest
{
    internal static partial class Extensions
    {
        public static string Base64UrlDecode(this string base64Url)
        {
            var base64 = base64Url;

            base64 = base64
                .PadRight(base64Url.Length + (4 - base64Url.Length % 4) % 4, '=')
                .Replace('-', '+') // 62nd char of encoding
                .Replace('_', '/'); // 63rd char of encoding

            var bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
