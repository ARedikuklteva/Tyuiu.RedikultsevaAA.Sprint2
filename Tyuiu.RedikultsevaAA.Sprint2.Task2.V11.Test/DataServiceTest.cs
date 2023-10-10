using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint2.Task2.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckingDotInShadedAres()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
