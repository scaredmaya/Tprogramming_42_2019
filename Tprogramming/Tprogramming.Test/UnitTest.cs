using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tprogramming;

namespace Tprogramming.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestNaN_TaskACalculate()
        {
            var result = Program.TaskA_Calculate(0.5, 0.3, 0, 10, 1).Length;
            Assert.AreNotEqual(double.NaN, result);
        }

        [TestMethod]
        public void TestNaN_TaskBCalculate()
        {
            var result = Program.TaskB_Calculate(0.5, 0.3, new double[] { 0, 10, 1 }).Length;
            Assert.AreNotEqual(double.NaN, result);
        }

        [TestMethod]
        public void TestEqual_TaskBCalculate()
        {
            //Исходные данные
            double a = 2;
            double b = 4.1;
            double[] xArray = new double[]
            {
                1.24,
                1.38,
                2.38,
                3.21,
                0.68
            };

            //Ответы
            double[] result1 = Program.TaskB_Calculate(a, b, xArray);
            double[] result2 = new double[] { 3.932854888916494, 3.8977825446614167, 3.478402378037273, 2.7017486473693855, 4.0310069433171973 };
            CollectionAssert.AreEqual(result1, result2);
        }
    }
}
