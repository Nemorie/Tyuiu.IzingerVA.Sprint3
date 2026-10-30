using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint3.Task0.V19.Lib;

namespace Tyuiu.IzingerVA.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double wait = 4.399;
            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
