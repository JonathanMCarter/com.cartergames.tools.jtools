using UnityEngine;

namespace JTools
{
    public static class GetGeneral
    {
        /// <summary>
        /// Gets the difference between the passed in values and returns the result...
        /// </summary>
        /// <param name="a">Int | a</param>
        /// <param name="b">Int | b</param>
        /// <returns>Int</returns>
        public static int Difference(int a, int b)
        {
            return a - b;
        }
        
        
        
        /// <summary>
        /// Gets the difference between the passed in values and returns the result as a positive number always...
        /// </summary>
        /// <param name="a">Int | a</param>
        /// <param name="b">Int | b</param>
        /// <returns>Int</returns>
        public static int DifferencePositive(int a, int b)
        {
            var _a = a;
            var _b = b;

            if (_a < 0)
                _a *= -1;

            if (_b < 0)
                _b *= -1;

            if (_a - _b < 0)
                return (_a - _b) * -1;
            else
                return (_a - _b);
        }
        
        
        
        /// <summary>
        /// Gets the difference between the passed in values and returns the result as a positive number always...
        /// </summary>
        /// <param name="a">Double | a</param>
        /// <param name="b">Double | b</param>
        /// <returns>Double</returns>
        public static double DifferencePositive(double a, double b)
        {
            var _a = a;
            var _b = b;

            if (_a < 0)
                _a *= -1;

            if (_b < 0)
                _b *= -1;

            if (_a - _b < 0)
                return (_a - _b) * -1;
            else
                return (_a - _b);
        }




        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Invert(int a)
        {
            return a * -1;
        }
        

        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static float Invert(float a)
        {
            return a * -1;
        }
        
        
        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Invert(double a)
        {
            return a * -1;
        }



        public static float Normalise(float a, float max, float min = 0f)
        {
            return (a - min) / (max - min);
        }


        /// <summary>
        /// Inverts a 0-1 range to 1-0
        /// </summary>
        /// <param name="value">The value to change</param>
        /// <returns>Float</returns>
        public static float Invert01(float value)
        {
            return Mathf.Clamp01(1f - value);
        }
    }
}