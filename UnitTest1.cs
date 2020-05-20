
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LAB5.Hour ex = new LAB5.Hour();
            int result = 2048;
            ex.Opens();
            Assert.AreEqual(result, ex.TotalPs());
        }
    }
}
