using System;
using System.Linq;

namespace pg.util
{
    public class BooleanUtility
    {
        public enum PetroglyphBoolType
        {
            YesNo = 0,
            TrueFalse = 1
        }

        private static readonly string[] PETROGLYPH_TRUE_STRING_TYPES = { "Yes", "True" };
        private static readonly string[] PETROGLYPH_FALSE_STRING_TYPES = { "No", "False" };

        public static bool Parse(string petroglyphBoolean, bool defaultReturn = false)
        {
            if (string.IsNullOrEmpty(petroglyphBoolean) || string.IsNullOrWhiteSpace(petroglyphBoolean))
            {
                return defaultReturn;
            }
            return PETROGLYPH_TRUE_STRING_TYPES.Contains(petroglyphBoolean.Trim(), StringComparer.InvariantCultureIgnoreCase);
        }
        public static string Parse(bool boolean, PetroglyphBoolType petroglyphBoolean = PetroglyphBoolType.YesNo)
        {
            return boolean ? PETROGLYPH_TRUE_STRING_TYPES[(int)petroglyphBoolean] : PETROGLYPH_FALSE_STRING_TYPES[(int)petroglyphBoolean];
        }
    }
}
