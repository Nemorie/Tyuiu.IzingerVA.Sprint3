using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IzingerVA.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2.0 * x;
                if (denominator == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = Math.Round((2.0 * x - 3.0) / denominator + 5.0 * x - 6.0, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
