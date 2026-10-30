using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.IzingerVA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double wait = -44.313;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
