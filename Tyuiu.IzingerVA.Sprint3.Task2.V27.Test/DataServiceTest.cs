using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.IzingerVA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            double wait = 0.69;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
