using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int year = 1990;
            int month = 7;
            string wait = "Июль";
            string res = ds.FindMonthName(year, month);
            Assert.AreEqual(wait, res);
        }
    }
}
