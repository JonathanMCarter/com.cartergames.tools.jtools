using UnityEngine;

namespace JTools
{
    public static class FloatExtension
    {
        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static float Invert(this float original)
        {
            return original * -1;
        }
        
        
        /// <summary>
        /// Inverts a 0-1 range to 1-0
        /// </summary>
        /// <param name="original">The value to change</param>
        /// <returns>Float</returns>
        public static float Invert01(this float original)
        {
            return Mathf.Clamp01(1f - original);
        }
    }
}