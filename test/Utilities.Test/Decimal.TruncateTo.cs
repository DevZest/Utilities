using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public class Decimal_TruncateTo
    {
        [TestMethod]
        public void Test()
        {
            {
                var x = 0.274M;
                Assert.AreEqual(0.27M, x.TruncateTo(2));
            }

            {
                var x = 0.275M;
                Assert.AreEqual(0.27M, x.TruncateTo(2));
            }
        }
    }
}
