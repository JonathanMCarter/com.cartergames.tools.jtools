using System.Collections.Generic;

namespace JTools.GetSet
{
    /// <summary>
    /// Provides many common dice rolls and returns the result of those rolls...
    /// </summary>
    public static class GetDiceRoll
    {
        /// <summary>
        /// Rolls a single D4 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D4()
        {
            return GetRandom.Int(1, 4);
        }
        
        
        
        /// <summary>
        /// Rolls a single D6 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D6()
        {
            return GetRandom.Int(1, 6);
        }
        
        
        
        /// <summary>
        /// Rolls a single D8 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D8()
        {
            return GetRandom.Int(1, 8);
        }
        
        
        
        /// <summary>
        /// Rolls a single D10 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D10()
        {
            return GetRandom.Int(1, 10);
        }
        
        
        
        /// <summary>
        /// Rolls a single D10 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D12()
        {
            return GetRandom.Int(1, 12);
        }
        
        
        
        /// <summary>
        /// Rolls a single D10 and returns the result...
        /// </summary>
        /// <returns>Int</returns>
        public static int D20()
        {
            return GetRandom.Int(1, 20);
        }
        
        
        
        /// <summary>
        /// Rolls multiple D4 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D4(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 4));
            }

            return _temp;
        }
        
        
        
        /// <summary>
        /// Rolls multiple D6 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D6(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 6));
            }

            return _temp;
        }
        
        
        
        /// <summary>
        /// Rolls multiple D8 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D8(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 8));
            }

            return _temp;
        }
        
        
        
        /// <summary>
        /// Rolls multiple D10 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D10(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 10));
            }

            return _temp;
        }

        
        
        /// <summary>
        /// Rolls multiple D12 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D12(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 12));
            }

            return _temp;
        }

        
        
        /// <summary>
        /// Rolls multiple D20 and returns the result...
        /// </summary>
        /// <param name="numberOfRolls">Int | Number of times to roll</param>
        /// <returns>List of Ints</returns>
        public static List<int> D20(int numberOfRolls)
        {
            List<int> _temp = new List<int>();

            for (int i = 0; i < numberOfRolls; i++)
            {
                _temp.Add(GetRandom.Int(1, 20));
            }

            return _temp;
        }
    }
}
