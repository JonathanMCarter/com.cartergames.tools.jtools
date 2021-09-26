//
//  Credit: https://gram.gs/gramlog/formatting-big-numbers-aa-notation/
//  Used for most of the code in this script, I made a change to improve the resulting string 
//  Decimals so it shows like 1.25K, 10.5K & 124K
//

using System;
using System.Collections.Generic;

namespace JTools
{
    /// <summary>
    /// Formats numbers into a generic K,M,B,T,aa,ab,ac format with decimal points based on the character length
    /// So 1234 = 1.23K, 12345 = 12.3K, 123456 = 123K, 1234567 = 1.23M etc....
    /// </summary>
    public static class MoneyFormat
    {
        /// <summary>
        /// The first character to use once bast the Trillion count...
        /// </summary>
        private static readonly int charA = Convert.ToInt32('a');
        
        /// <summary>
        /// The unit types to desiplay before the "aa", "ab", "ac" etc.....
        /// </summary>
        private static readonly Dictionary<int, string> Units = new Dictionary<int, string>
        {
            {0, ""},
            {1, "K"},
            {2, "M"},
            {3, "B"},
            {4, "T"}
        };
        
        
        /// <summary>
        /// Formats the entered value into a K,M,B style format...
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <returns>The resulting string formatted</returns>
        public static string Format(double value)
        {
            return FormatValue(value);
        }


        /// <summary>
        /// Formats the entered value into a K,M,B style format...
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <returns>The resulting string formatted</returns>
        public static string Format(float value)
        {
            return FormatValue(value);
        }
        
        
        /// <summary>
        /// Formats the entered value into a K,M,B style format...
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <returns>The resulting string formatted</returns>
        public static string Format(int value)
        {
            return FormatValue(value);
        }


        /// <summary>
        /// Does the actual formatting of the values entered...
        /// </summary>
        /// <param name="value">The value to read</param>
        /// <returns>The string result to return</returns>
        private static string FormatValue(double value)
        {
            if (value < 1d)
                return "0";

            var n = (int) Math.Log(value, 1000);
            var m = value / Math.Pow(1000, n);
            var unit = "";
 
            if (n < Units.Count)
                unit = Units[n];
            else
            {
                var unitInt = n - Units.Count;
                var secondUnit = unitInt % 26;
                var firstUnit = unitInt / 26;
                unit = Convert.ToChar(firstUnit + charA) + Convert.ToChar(secondUnit + charA).ToString();
            }
 
            // Math.Floor(m * 100) / 100) fixes rounding errors
            var _result = Math.Floor(m * 100) / 100;

            // Sorts the decimals out into the format I wanted xD
            if (_result >= 100)
                return _result.ToString("F0") + unit;
            if (_result >= 10)
                return _result.ToString("F1") + unit;

            return _result.ToString("F2") + unit;
        }
    }
}