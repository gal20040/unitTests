using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeClassLibrary;

namespace MSTests
{
    [TestClass]
    public class UnitTest1
    {

        [DataTestMethod]
        [DataRow(1, 3,  true)]
        [DataRow(0, 2,  true)]
        [DataRow(0, 3, false)]
        public void TestMethod1(int x, int y, bool expected)
        {
            var actual = new Class().Test(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
