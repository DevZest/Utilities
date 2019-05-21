namespace DevZest
{
    internal static partial class Extensions
    {
        public static string Base64UrlEncode(this string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            var result = System.Convert.ToBase64String(plainTextBytes);

            result = result.Replace("=", string.Empty); // Remove any trailing '='s
            result = result.Replace('+', '-'); // 62nd char of encoding
            result = result.Replace('/', '_'); // 63rd char of encoding

            return result;
        }
    }
}
