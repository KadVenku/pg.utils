using System;
using System.Globalization;

namespace pg.util
{
    public class IntegerUtility
    {
        private static readonly CultureInfo INV_CULTURE_INFO = CultureInfo.GetCultureInfo("en-US");

        internal static int Parse(string integerValue)
        {
            if (string.IsNullOrEmpty(integerValue) || string.IsNullOrWhiteSpace(integerValue))
            {
                return 0;
            }

            try
            {
                return int.Parse(integerValue, NumberStyles.Integer, INV_CULTURE_INFO);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        internal static string Parse(int integerValue)
        {
            return integerValue.ToString(INV_CULTURE_INFO);
        }
    }
}
