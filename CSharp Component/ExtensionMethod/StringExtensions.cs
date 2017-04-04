
using System;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if the string is null or empty. Note: a string containing white space is not considerered empty
        /// </summary>
        /// <param name="value">The value to check</param>
        /// <returns>True f the string is null or empty</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            if (value == null || String.Equals(value, string.Empty, StringComparison.InvariantCulture))
            {
                return true;
            }

            return false;
        }
    }
}
