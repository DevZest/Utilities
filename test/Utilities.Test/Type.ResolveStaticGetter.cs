using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevZest
{
    [TestClass]
    public class Type_ResolveStaticGetter
    {
        private const string ERROR_MESSAGE = "This is a error message.";

        private static string ErrorMessage
        {
            get { return ERROR_MESSAGE; }
        }

        [TestMethod]
        public void Test()
        {
            var stringGetter = typeof(Type_ResolveStaticGetter).ResolveStaticGetter<string>(nameof(ErrorMessage));
            Assert.AreEqual(ERROR_MESSAGE, stringGetter());
        }
    }
}
