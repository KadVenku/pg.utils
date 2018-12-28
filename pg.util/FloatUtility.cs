using System.Globalization;

namespace pg.util
{
    public class FloatUtility
    {
        private static readonly CultureInfo INV_CULTURE_INFO = CultureInfo.GetCultureInfo("en-US");
        public static float Parse(string floatValue)
        {
            if (string.IsNullOrEmpty(floatValue) || string.IsNullOrWhiteSpace(floatValue))
            {
                return 0.0f;
            }
            return float.Parse(floatValue, INV_CULTURE_INFO);
        }

        public static string Parse(float floatValue)
        {
            return floatValue.ToString(INV_CULTURE_INFO);
        }
        public static string Parse(float floatValue, int decimalPlaces)
        {
            return floatValue.ToString("F" + decimalPlaces, INV_CULTURE_INFO);
        }
    }
}
