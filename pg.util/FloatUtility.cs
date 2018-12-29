using System.Globalization;

namespace pg.util
{
    /// <summary>
    /// A convenience class to handle Petroglyph's float types.
    /// </summary>
    public class FloatUtility
    {
        private static readonly CultureInfo INV_CULTURE_INFO = CultureInfo.GetCultureInfo("en-US");
        /// <summary>
        /// Parses the specified string as float value.
        /// </summary>
        /// <param name="floatValue">The string that should be parsed as float value.</param>
        /// <returns></returns>
        public static float Parse(string floatValue)
        {
            if (string.IsNullOrEmpty(floatValue) || string.IsNullOrWhiteSpace(floatValue))
            {
                return 0.0f;
            }
            floatValue = floatValue.Replace('f', ' ');
            floatValue = floatValue.Replace('F', ' ');
            floatValue = floatValue.Trim();
            return float.Parse(floatValue, INV_CULTURE_INFO);
        }

        /// <summary>
        /// Parses the specified float value that should be parsed as string.
        /// </summary>
        /// <param name="floatValue">The float value.</param>
        /// <param name="decimalPlaces">The decimal places.</param>
        /// <returns></returns>
        public static string Parse(float floatValue, int decimalPlaces = 0)
        {
            return floatValue.ToString("F" + decimalPlaces, INV_CULTURE_INFO);
        }
    }
}
