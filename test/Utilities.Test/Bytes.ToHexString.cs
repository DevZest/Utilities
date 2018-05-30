using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public partial class ExtensionsTests
    {
        [TestMethod]
        public void Bytes_ToHexString()
        {
            var bytes = new byte[] { 5, 10, 127, 255 };
            Assert.AreEqual("050A7FFF", bytes.ToHexString());
        }
    }
}
