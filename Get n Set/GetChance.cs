using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.GetSet
{
    /// <summary>
    /// Gets chance based on the inputted values...
    /// </summary>
    public static class GetChance
    {
        /// <summary>
        /// Rolls a 50/50 check, and returns the result when using the getter.
        /// </summary>
        public static bool Roll5050
        {
            get
            {
                return System.Convert.ToBoolean(Mathf.FloorToInt(Random.Range(0f, 1f)));
            }
        }
        


        /// <summary>
        /// Rolls out of 100 and returns whether or not the user won or lost.
        /// </summary>
        /// <param name="chanceOfSuccess">Int | The chance in percentage that the user will win.</param>
        /// <returns>Bool | True if the user won, false if not.</returns>
        public static bool Roll100(int chanceOfSuccess)
        {
            int _roll = Mathf.RoundToInt(Random.Range(1f, 100f));

            if (_roll <= chanceOfSuccess)
                return true;
            else
                return false;
        }
        
        
        
        /// <summary>
        /// Rolls out of 100 and returns whether or not the user won or lost.
        /// </summary>
        /// <param name="chanceOfSuccess">Int | The chance in percentage that the user will win.</param>
        /// <returns>Bool | True if the user won, false if not.</returns>
        public static bool Roll100(float chanceOfSuccess)
        {
            float _roll = Random.Range(1f, 100f);

            if (_roll <= chanceOfSuccess)
                return true;
            else
                return false;
        }


        
        /// <summary>
        /// Returns a roll based on a 1 in x style of of chance, like a drop table...
        /// </summary>
        /// <param name="x">Int | The chance /1 that this will be true...</param>
        /// <returns>Bool</returns>
        public static bool OneInX(int x)
        {
            float _roll = Random.Range(1, x + 1);

            if (_roll.Equals(1))
                return true;

            return false;
        }
    }
}