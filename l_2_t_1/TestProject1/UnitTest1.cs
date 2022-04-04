using Microsoft.VisualStudio.TestTools.UnitTesting;
using l_2_t_1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 34;
            int expres = 7;
            int result = Class1.doSum(number);

            Assert.AreEqual(expres, result);
        }
        
    }
}