using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUnitTest.Tests
{
    [TestClass()]
    public class MathTests
    {
        [TestMethod()]
        public void DivinTest()
        {
            double x1 = 999;
            double x2 = 9;

            var m = new Math();
            double? res = m.Divin(x1, x2);

            Assert.AreEqual(111, res);
        }

        [TestMethod()]
        public void MultipTest()
        {
            double x1 = 202;
            double x2 = 9;

            var m = new Math();
            double res = m.Multip(x1, x2);

            Assert.AreEqual(1818, res);
        }

        [TestMethod()]
        public void DivinTest1()
        {
            double x1 = 999;
            double x2 = 0;


            var m = new Math();
            double? res = m.Divin(x1, x2);

            Assert.AreEqual(null, res);
        }

        [TestMethod()]
        public void AddTest()
        {
            double x1 = 999;
            double x2 = 1;

            var m = new Math();
            double? res = m.Add(x1, x2);

            Assert.AreEqual(1000, res);
        }

        [TestMethod()]
        public void SubtractionTest()
        {

            double x1 = 1991;
            double x2 = 11;

            var m = new Math();
            double? res = m.Subtraction(x1, x2);

            Assert.AreEqual(1980, res); 
        }
    }
}