using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public class String_Base64
    {
        [TestMethod]
        public void String_Base64EncodeDecode()
        {
            var text = "plain text";
            var encoded = text.Base64Encode();
            Assert.AreEqual("cGxhaW4gdGV4dA==", encoded);
            var decoded = encoded.Base64Decode();
            Assert.AreEqual(text, decoded);
        }
    }
}
