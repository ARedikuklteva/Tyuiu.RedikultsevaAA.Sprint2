using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.1.2005", ds.FindDateOfNextDay(2004, 12, 31));
        }
    }
}
