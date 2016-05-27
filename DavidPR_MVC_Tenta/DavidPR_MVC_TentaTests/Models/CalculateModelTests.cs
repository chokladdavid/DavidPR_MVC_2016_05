using Microsoft.VisualStudio.TestTools.UnitTesting;
using DavidPR_MVC_Tenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidPR_MVC_Tenta.Models.Tests
{
    [TestClass()]
    public class CalculateModelTests
    {
        [TestMethod()]
        public void GetCurrentSpeedTest_EmtyString()
        {
            CalculateModel model = new CalculateModel();

            var actual = model.GetCurrentSpeed("20", "");
            var expected = -1.0M;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void GetCurrentSpeedTest_NotANumber()
        {
            CalculateModel model = new CalculateModel();

            var actual = model.GetCurrentSpeed("20m", "2h");
            var expected = -1.0M;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void GetCurrentSpeedTest_NegetivValues()
        {
            CalculateModel model = new CalculateModel();

            var actual = model.GetCurrentSpeed("-20", "-2");
            var expected = 10.0M;
            Assert.AreEqual(actual, expected);
        }
    }
}