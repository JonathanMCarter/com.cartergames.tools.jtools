// ----------------------------------------------------------------------------
// TimeFormat.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 01/10/2021
// ----------------------------------------------------------------------------

using System;

namespace JTools
{
    /// <summary>
    /// Formats numbers into a variety of time formats to display...
    /// </summary>
    public static class TimeFormat
    {
        /// <summary>
        /// Display the value in a stopwatch style...
        /// </summary>
        /// <param name="value">The value to read</param>
        /// <returns>The formatted string</returns>
        public static string StopWatch(float value)
        {
            if (value >= 10)
                return value.ToString("c").Substring(1, 5);
            
            return value.ToString("c").Substring(1, 4);
        }

        
        /// <summary>
        /// Display the value as a mm:ss style...
        /// </summary>
        /// <param name="value">The value to read</param>
        /// <param name="format">The string format to use, default is mm:ss</param>
        /// <returns>The formatted string</returns>
        public static string MinutesSeconds(float value, string format = "mm':'ss")
        {
            var time = TimeSpan.FromSeconds(value);
            return time.ToString(format);
        }
        
        
        /// <summary>
        /// Display the value as a hh:mm:ss style...
        /// </summary>
        /// <param name="value">The value to read</param>
        /// <param name="format">The string format to use, default is hh:mm:ss</param>
        /// <returns>The formatted string</returns>
        public static string HoursMinutesSeconds(float value, string format = "hh':'mm':'ss")
        {
            var time = TimeSpan.FromSeconds(value);
            return time.ToString(format);
        }
    }
}