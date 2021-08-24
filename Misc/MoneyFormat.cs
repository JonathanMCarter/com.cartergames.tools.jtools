using System;
using System.Globalization;

/*
*  Copyright (c) Jonathan Carter
*  E: jonathan@carter.games
*  W: https://jonathan.carter.games/
*/

namespace JTools
{
    public static class MoneyFormat
    {
        private const float HundredTrillion = 100000000000000;
        private const float TenTrillion = 10000000000000;
        private const float Trillion = 1000000000000;
        private const float HundredBillion = 100000000000;
        private const float TenBillion = 10000000000;
        private const float Billion = 1000000000;
        private const float HundredMillion = 100000000;
        private const float TenMillion = 10000000;
        private const float Million = 1000000;
        private const float HundredKay = 100000;
        private const float TenKay = 10000;
        private const float OneKay = 1000;
        
        
        public enum FormatStyles { Suffixed, Scientific }


        public static string ShowFormatted(double toRead, FormatStyles style)
        {
            switch (style)
            {
                case FormatStyles.Suffixed:
                    
                    NumberFormatInfo nfi = new NumberFormatInfo();

                    if (toRead >= Trillion)
                        return StandardFormatting(toRead, nfi, HundredTrillion, TenTrillion, Trillion, 'T');
                    else if (toRead < Trillion && toRead >= Billion)
                        return StandardFormatting(toRead, nfi, HundredBillion, TenBillion, Billion, 'B');
                    else if (toRead < Billion && toRead >= Million)
                        return StandardFormatting(toRead, nfi, HundredMillion, TenMillion, Million, 'M');
                    else
                        return StandardFormatting(toRead, nfi, HundredKay, TenKay, OneKay, 'K');
                    
                    break;
                case FormatStyles.Scientific:

                    return ShowScientificFormatted(toRead);
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(style), style, null);
            }
        }


        private static string ShowScientificFormatted(double toRead)
        {
            return ScientificFormat(toRead);
        }


        /// <summary>
        /// Formats the number entered into a currency value.
        /// </summary>
        /// <param name="toRead">Double | The double to convert.</param>
        /// <param name="nfi">NumberFormatInfo | The number formatting info to pass through.</param>
        /// <param name="hundred">Double | The 100x variant of the grouping to convert.</param>
        /// <param name="ten">Double | The 10x variant of the grouping to convert.</param>
        /// <param name="one">Double | The 1x variant of the grouping to convert.</param>
        /// <param name="suffix">Char | The suffix to apply to the grouping once converted.</param>
        /// <returns>String | The newly converted value as a string.</returns>
        private static string StandardFormatting(double toRead, NumberFormatInfo nfi, double hundred, double ten, double one, char suffix)
        {
            switch (toRead)
            {
                case var _ when toRead > hundred:
                    nfi.NumberDecimalDigits = 0;
                    return (toRead / one).ToString("N", nfi) + suffix;

                case var _ when toRead.Equals(hundred):
                    nfi.NumberDecimalDigits = 0;
                    return toRead.ToString("N", nfi).Substring(0, 3) + suffix;

                case var _ when toRead > ten:
                    nfi.NumberDecimalDigits = 1;
                    return Simplify((toRead / one).ToString("N", nfi), toRead, nfi, one, suffix);

                case var _ when toRead.Equals(ten):
                    nfi.NumberDecimalDigits = 0;
                    return toRead.ToString("N", nfi).Substring(0, 2) + suffix;

                case var _ when toRead > OneKay:
                    nfi.NumberDecimalDigits = 2;
                    return Simplify((toRead / one).ToString("N", nfi), toRead, nfi, one, suffix);

                case var _ when toRead.Equals(one):
                    nfi.NumberDecimalDigits = 0;
                    return toRead.ToString("N", nfi).Substring(0, 1) + suffix;

                default:
                    nfi.NumberDecimalDigits = 0;
                    return toRead.ToString("N", nfi);
            }
        }


        /// <summary>
        /// Simplifies the string to remove 0 decimals where applicable.
        /// </summary>
        /// <param name="strToRead">String | The string that is to be returned.</param>
        /// <param name="toRead">Double | The amount in a normal double value.</param>
        /// <param name="nfi">NumberFormatInfo | The formatting info for decimal points.</param>
        /// <param name="divideBy">Double | The amount to divide by.</param>
        /// <param name="suffix">Char | The suffix char for that should be returned.</param>
        /// <returns>String | The newly formatted string if applicable, if not the it returns the strToRead variable as is.</returns>
        private static string Simplify(string strToRead, double toRead, NumberFormatInfo nfi, double divideBy, char suffix)
        {
            if (strToRead.Substring(2, 2).Equals("00"))
                return toRead.ToString("N", nfi).Substring(0, 1) + suffix;
            else if (strToRead.Substring(3, 1).Equals("0") && strToRead.Substring(2,1).Equals("."))
                return (toRead / divideBy).ToString("N", nfi).Substring(0, 2) + suffix;
            else if (strToRead.Substring(3, 1).Equals("0"))
                return (toRead / divideBy).ToString("N", nfi).Substring(0, 3) + suffix;
            else
                return strToRead + suffix;
        }


        private static string ScientificFormat(double toRead)
        {
            if (toRead >= TenKay)
                return Simplify(toRead);
            else
            {
                var _nfi = new NumberFormatInfo();
                _nfi.NumberDecimalDigits = 0;
                return toRead.ToString("N", _nfi);
            }
        }
        
        
        /// <summary>
        /// Simplifies the string to remove 0 decimals where applicable.
        /// </summary>
        /// <param name="strToRead">String | The string that is to be returned.</param>
        /// <param name="toRead">Double | The amount in a normal double value.</param>
        /// <param name="nfi">NumberFormatInfo | The formatting info for decimal points.</param>
        /// <param name="divideBy">Double | The amount to divide by.</param>
        /// <param name="suffix">Char | The suffix char for that should be returned.</param>
        /// <returns>String | The newly formatted string if applicable, if not the it returns the strToRead variable as is.</returns>
        private static string Simplify(double toRead)
        {
            return toRead.ToString("G3").Substring(0, 5) + toRead.ToString("G3").Substring(toRead.ToString("G3").Length - 1, 1);
        }
    }
}