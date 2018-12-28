using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pg.util.tests
{
    [TestClass]
    public class BooleanUtilityTest
    {
        [TestMethod]
        [DataRow(null, true)]
        [DataRow("", true)]
        [DataRow("    ", true)]
        [DataRow("\t\n\n  \n\t\t", true)]
        public void ParseStringToTrueNullCheck(string s, bool b)
        {
            bool val = BooleanUtility.Parse(s, true);
            Assert.IsTrue(val);
        }

        [TestMethod]
        [DataRow("yes")]
        [DataRow("Yes")]
        [DataRow("YES")]
        [DataRow("\tyes\n")]
        [DataRow("  \t\n\nYes  \t")]
        [DataRow("  \t\nYES   \t\n\t\t")]
        public void ParseStringToBoolTrue(string testString)
        {
            bool val = BooleanUtility.Parse(testString);
            Assert.IsTrue(val);
        }
        [TestMethod]
        [DataRow("yes", BooleanUtility.PetroglyphBoolType.YesNo)]
        [DataRow("Yes", BooleanUtility.PetroglyphBoolType.YesNo)]
        [DataRow("YES", BooleanUtility.PetroglyphBoolType.YesNo)]
        [DataRow("true", BooleanUtility.PetroglyphBoolType.TrueFalse)]
        [DataRow("True", BooleanUtility.PetroglyphBoolType.TrueFalse)]
        [DataRow("TRUE", BooleanUtility.PetroglyphBoolType.TrueFalse)]
        public void ParseStringToBoolTruePGBoolType(string testString, BooleanUtility.PetroglyphBoolType boolType)
        {
            bool val = BooleanUtility.Parse(testString);
            Assert.IsTrue(val);
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ParseBoolToStringYesNo(bool b)
        {
            string[] yesNoTypeStrings = {"Yes", "No"};
            string val = BooleanUtility.Parse(b, BooleanUtility.PetroglyphBoolType.YesNo);
            Assert.IsTrue(yesNoTypeStrings.Contains(val) && b ? val.Equals("Yes", StringComparison.InvariantCultureIgnoreCase) : val.Equals("No", StringComparison.CurrentCultureIgnoreCase));
        }
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ParseBoolToStringTrueFalse(bool b)
        {
            string[] yesNoTypeStrings = { "True", "False" };
            string val = BooleanUtility.Parse(b, BooleanUtility.PetroglyphBoolType.TrueFalse);
            Assert.IsTrue(yesNoTypeStrings.Contains(val) && b ? val.Equals("True", StringComparison.InvariantCultureIgnoreCase) : val.Equals("False", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
