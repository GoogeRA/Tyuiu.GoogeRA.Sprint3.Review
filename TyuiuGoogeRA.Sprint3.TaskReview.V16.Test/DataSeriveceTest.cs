using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint3.TaskReview.V16.Lib;

namespace TyuiuGoogeRA.Sprint3.TaskReview.V16.Test
{
    [TestClass]
    public class DataSeriveceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] v;
            v = new double[len];

            v[0] = 36.41;
            v[1] = -22.07;
            v[2] = 5.68;
            v[3] = 16.72;
            v[4] = 8.35;
            v[5] = -0.50;
            v[6] = 9.63;
            v[7] = 16.29;
            v[8] = 5.01;
            v[9] = -22.40;
            v[10] = -36.30;

            double[] res;
            res = new double[len];
            res = service1.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(v, res);
        }
    }
}
