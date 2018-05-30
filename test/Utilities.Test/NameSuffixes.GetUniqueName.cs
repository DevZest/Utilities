using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DevZest
{
    [TestClass]
    public class NameSuffixes_GetUniqeNameTests
    {
        [TestMethod]
        public void Test()
        {
            var suffixes = new Dictionary<string, int>();
            Assert.AreEqual("name", suffixes.GetUniqueName("name"));
            Assert.AreEqual("name1", suffixes.GetUniqueName("name"));
            Assert.AreEqual("name2", suffixes.GetUniqueName("name"));
            Assert.AreEqual("name1_1", suffixes.GetUniqueName("name1"));
            Assert.AreEqual("name1_2", suffixes.GetUniqueName("name1"));
        }
    }
}
