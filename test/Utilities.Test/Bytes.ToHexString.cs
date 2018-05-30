using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public class Bytes_ToHexString
    {
        [TestMethod]
        public void Test()
        {
            var bytes = new byte[] { 5, 10, 127, 255 };
            Assert.AreEqual("050A7FFF", bytes.ToHexString());
        }
    }
}
