using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IzingerVA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    res += chr;
                }
            }
            return Convert.ToInt32(res);
        }
    }
}
