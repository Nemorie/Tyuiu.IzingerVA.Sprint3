using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IzingerVA.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            do
            {
                sumSeries += Math.Pow(4.0 / (1.0 + Math.Pow(value, i)), i);
                i++;
            } while (i <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}
