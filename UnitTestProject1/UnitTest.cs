using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTests;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [DataTestMethod]
        [DataRow(1, 3, true)]
        [DataRow(0, 2, true)]
        //[DataRow(0, 3, false)]
        public void TestMethod1(int x, int y, bool expected)
        {
            var actual = new Class().Test(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}