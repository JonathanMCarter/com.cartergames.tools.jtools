using UnityEngine;

namespace JTools
{
    public static class IntExtension
    {
        /// <summary>
        /// Inverts the value...
        /// </summary>
        /// <param name="original">The value to edit...</param>
        /// <returns>The inverted value</returns>
        public static int Invert(this int original)
        {
            return original * -1;
        }
    }
}