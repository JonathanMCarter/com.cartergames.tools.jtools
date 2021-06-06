namespace JTools.GetSet
{
    public static class Get
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





        public static int Negative(int a)
        {
            return a * -1;
        }
    }
}