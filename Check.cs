using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;


namespace JTools
{
    /// <summary>
    /// Static Class | Check, several checks that take a lot of lines, condensed to save space.
    /// </summary>
    public static class Check
    {
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if the desired string is in the array of strings provided
        /// Added In: The Isolation of Isabelle.
        /// </summary>
        /// <param name="toFind">String | To search for</param>
        /// <param name="strings">String Array | to look through</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool StringInArray(string toFind, string[] strings)
        {
            return strings.Any(_t => _t.Equals(toFind));
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if the current position is within a threshold of the target position
        /// Added In: The Isolation of Isabelle.
        /// </summary>
        /// <param name="threshold">how much off can the vector3 be?</param>
        /// <param name="target">the target Vector3</param>
        /// <param name="current">the current Vector3</param>
        /// <param name="ignoreYAxis">should the Y axis be checked?</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool WithinThreshold(float threshold, Vector3 target, Vector3 current, bool ignoreYAxis = true)
        {
            if (ignoreYAxis)
            {
                return current.x + threshold > target.x - threshold &&
                       current.x - threshold < target.x + threshold &&
                       current.z + threshold > target.z - threshold &&
                       current.z - threshold < target.z + threshold;
            }
            else
            {
                return current.x + threshold > target.x - threshold &&
                       current.x - threshold < target.x + threshold &&
                       current.y + threshold > target.y - threshold &&
                       current.y - threshold < target.y + threshold &&
                       current.z + threshold > target.z - threshold &&
                       current.z - threshold < target.z + threshold;
            }
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if a layer is present in the hits of a raycast, true if there is, false if not
        /// Added In: The Isolation of Isabelle.
        /// </summary>
        /// <param name="hits">Raycasthits to check.</param>
        /// <param name="layerToCheck">layer int to find</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool RaycastLayerCheck(List<UnityEngine.EventSystems.RaycastResult> hits, int layerToCheck)
        {
            return hits.Any(_t => _t.gameObject.layer.Equals(layerToCheck));
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks the two inputted Color32's to see if they are the same.
        /// Added In: Crushing!
        /// </summary>
        /// <param name="colourA">First colour to check</param>
        /// <param name="colourB">Second colour to check</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool Color32Check(Color32 colourA, Color32 colourB)
        {
            return (colourA.r == colourB.r) && (colourA.g == colourB.g) && (colourA.b == colourB.b) && (colourA.a == colourB.a);
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if a colour matches a float array of 4 elements.
        /// Added In: Crushing!
        /// </summary>
        /// <param name="col">The colour to check.</param>
        /// <param name="array">The float array of 4 to check.</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool ColorVsFloatArrayCheck(Color col, float[] array)
        {
            return (col.r == array[0]) && (col.g == array[1]) && (col.b == array[2]) && (col.a == array[3]);
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see which is the two values is higher, regardless of +/-.
        /// Added In: No Present For You.
        /// </summary>
        /// <param name="value0">Value 0 to check</param>
        /// <param name="value1">Value 1 to check</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool FaceValueCheck(float value0, float value1)
        {
            float _check0, _check1;

            if (value0 < 0)
                _check0 = value0 * -1;
            else
                _check0 = value0;

            if (value1 < 0)
                _check1 = value1 * -1;
            else
                _check1 = value1;
            
            return _check0 > _check1;
        }
        
        
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see which is the two values is higher, regardless of +/-.
        /// Added In: No Present For You.
        /// </summary>
        /// <param name="value0">Value 0 to check</param>
        /// <param name="value1">Value 1 to check</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool FaceValueEqualsCheck(float value0, float value1)
        {
            float _check0, _check1;

            if (value0 < 0)
                _check0 = value0 * -1;
            else
                _check0 = value0;

            if (value1 < 0)
                _check1 = value1 * -1;
            else
                _check1 = value1;
            
            return _check0.Equals(_check1);
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if a value is within the defined min and max values.
        /// Added In: Detective Notes.
        /// </summary>
        /// <param name="toCheck">Int | The value to check</param>
        /// <param name="lowerBound">Int | The lower value</param>
        /// <param name="UpperBound">Int | The upper value</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool IsWithinBounds(int toCheck, int lowerBound, int UpperBound)
        {
            return toCheck >= lowerBound && toCheck <= UpperBound;
        }
        
        
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if a value is within the defined min and max values.
        /// Added In: Detective Notes.
        /// </summary>
        /// <param name="toCheckMin">Int | The min value to check</param>
        /// <param name="toCheckMax">Int | The max value to check</param>
        /// <param name="lowerBound">Int | The lower value</param>
        /// <param name="UpperBound">Int | The upper value</param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool IsWithinBounds(int toCheckMin, int toCheckMax, int lowerBound, int UpperBound)
        {
            return toCheckMin >= lowerBound && toCheckMax <= UpperBound;
        }

        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if Vector2 b has moved in any direction from Vector2 a further than the amount specified.
        /// Added In: (NDA)
        /// </summary>
        /// <param name="a">Vector2 | Initial Vector2</param>
        /// <param name="b">Vector2 | Current Vector2 (Normally the current position).</param>
        /// <param name="amount">Float | The amount the user needs to move to </param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool Vector2GreaterThanXOnAnyAxis(Vector2 a, Vector2 b, float amount)
        {
            return (b.x > a.x + amount) || (b.x < a.x - amount) ||
                   (b.y > a.y + amount) || (b.y < a.y - amount);
        }

        
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks to see if Vector3 b has moved in any direction from Vector3 a further than the amount specified.
        /// Added In: (NDA)
        /// </summary>
        /// <param name="a">Vector3 | Initial Vector3</param>
        /// <param name="b">Vector3 | Current Vector3 (Normally the current position).</param>
        /// <param name="amount">Float | The amount the user needs to move to </param>
        /// <returns>Bool | Result of check.</returns>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool Vector3GreaterThanXOnAnyAxis(Vector3 a, Vector3 b, float amount)
        {
            return (b.x > a.x + amount) || (b.x < a.x - amount) ||
                   (b.y > a.y + amount) || (b.y < a.y - amount) ||
                   (b.z > a.z + amount) || (b.z < a.z - amount);
        }



        public static bool ArrayHasAValue(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(0))
                {
                    return true;
                }
            }
            
            return false;
        }



        public static bool GreaterThanZeroInList(List<int> toCheck)
        {
            for (int i = 0; i < toCheck.Count; i++)
            {
                if (toCheck[i] <= 0) continue;

                return true;
            }

            return false;
        }
    }
}