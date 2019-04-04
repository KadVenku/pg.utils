using System;
using System.Linq;

namespace pg.util
{
    /// <summary>
    /// A convenience class to handle Petroglyph's boolean types.
    /// </summary>
    public sealed class BooleanUtility
    {
        /// <summary>
        /// Defines the types from the values used by Petroglyph as booleans in their xml files.
        /// </summary>
        public enum PetroglyphBoolType
        {
            /// <summary>
            /// Can be used to properly parse the attributes that use "yes" and "no" respectively as stand-ins for booleans in their xml tags.
            /// </summary>
            YesNo = 0,
            /// <summary>
            /// Can be used to properly parse the attributes that use "true" and "false" respectively as stand-ins for booleans in their xml tags.
            /// </summary>
            TrueFalse = 1
        }

        private static readonly string[] PETROGLYPH_TRUE_STRING_TYPES = { "Yes", "True" };
        private static readonly string[] PETROGLYPH_FALSE_STRING_TYPES = { "No", "False" };

        /// <summary>Parses the specified Petroglyph boolean found in Petroglyph games.</summary>
        /// <param name="petroglyphBoolean">The string as read from the xml value.</param>
        /// <param name="defaultReturn">If the provided string value cannot be parsed, this default will be returned instead.</param>
        /// <returns></returns>
        public static bool Parse(string petroglyphBoolean, bool defaultReturn = false)
        {
            if (string.IsNullOrEmpty(petroglyphBoolean) || string.IsNullOrWhiteSpace(petroglyphBoolean))
            {
                return defaultReturn;
            }
            return PETROGLYPH_TRUE_STRING_TYPES.Contains(petroglyphBoolean.Trim(), StringComparer.InvariantCultureIgnoreCase);
        }
        /// <summary>Parses the specified boolean and turns it into a Petroglyph boolean type as used in the xml files for Petroglyph games.</summary>
        /// <param name="boolean">The boolean to parse.</param>
        /// <param name="petroglyphBoolean">The type the boolean should be parsed as. Defaults to the YesNo type.</param>
        /// <returns>Returns a string that can be used as boolean for xml attributes in Petroglyph games.</returns>
        public static string Parse(bool boolean, PetroglyphBoolType petroglyphBoolean = PetroglyphBoolType.YesNo)
        {
            return boolean ? PETROGLYPH_TRUE_STRING_TYPES[(int)petroglyphBoolean] : PETROGLYPH_FALSE_STRING_TYPES[(int)petroglyphBoolean];
        }
    }
}
