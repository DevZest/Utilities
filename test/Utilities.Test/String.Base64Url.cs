using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public class String_Base64Url
    {
        [TestMethod]
        public void String_Base64UrlEncodeDecode()
        {
            var text = "plain text";
            var encoded = text.Base64UrlEncode();
            Assert.AreEqual("cGxhaW4gdGV4dA", encoded);
            var decoded = encoded.Base64UrlDecode();
            Assert.AreEqual(text, decoded);
        }
    }
}
