using UnityEngine;

namespace JTools
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="original"></param>
        /// <returns>Double</returns>
        public static double Invert(this double original)
        {
            return original * -1;
        }
    }
}