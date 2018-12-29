using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pg.util.tests
{
    [TestClass]
    public class FloatUtilityTest
    {
        [TestMethod]
        [DataRow("\t1.234\n\t")]
        [DataRow("1.234")]
        [DataRow("\t2.345f    ")]
        public void ParseStringToFloatNotNull(string s)
        {
            float val = FloatUtility.Parse(s);
            Assert.IsTrue(val > 0.0f || val < 0.0f);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("\t\n\t\t   \t")]
        public void ParseStringToFloatNull(string s)
        {
            float val = FloatUtility.Parse(s);
            Assert.IsTrue(val == 0.0f);
        }

        [TestMethod]
        [DataRow(0.0f)]
        [DataRow(1.2345f)]
        [DataRow(1.5678f)]
        public void ParseFloatToStringNoDecimal(float f)
        {
            string val = FloatUtility.Parse(f);
            Assert.IsTrue(val == "0" || val =="1" || val=="2");
        }
        
        [TestMethod]
        [DataRow(0.0f)]
        [DataRow(1.2345f)]
        [DataRow(1.5678f)]
        public void ParseFloatToStringTwoDecimal(float f)
        {
            string val = FloatUtility.Parse(f, 2);
            Assert.IsTrue(val == "0.00" || val =="1.23" || val=="1.57");
        }
    }
}
