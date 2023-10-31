using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GoogeRA.Sprint3.TaskReview.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] v;
            int len = (stopValue - startValue) + 1;
            v = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    v[count] = 0.00;
                    count++;
                    continue;
                }
                y = Math.Round(((Math.Cos(x) / ( x - 0.4)) + Math.Sin(x) * 8 * x +2));
                v[count] = y;
                count++;

            }
            return v;
        }
    }
}
