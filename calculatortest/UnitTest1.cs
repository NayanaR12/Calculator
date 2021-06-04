using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculatorapp;
namespace calculatortest
{
   
    [TestClass]
    public class UnitTest1
    {
        Calculator obj = new Calculator();
        [TestMethod]

        public void TestMethod1()
        {
            int actual = obj.add(12, 10);
            int expected = 22;
            Assert.AreEqual(expected, actual);
        }
    }
}
