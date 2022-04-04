using Microsoft.VisualStudio.TestTools.UnitTesting;
using l_2_t_2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0;
            double y = 0;  

            double expres = 0;  
            double result = Class1.check(x, y);

            Assert.AreEqual(expres, result); 
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = 1;
            double y = 3;

            double expres = 1;
            double result = Class1.check(x, y);

            Assert.AreEqual(expres, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double x = 20;
            double y = 25;

            double expres = -1;
            double result = Class1.check(x, y);

            Assert.AreEqual(expres, result);
        }
    }
}