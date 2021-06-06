using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;


namespace JTools.GetSet
{
    /// <summary>
    /// Static Class | Get a random.... choose a property/method to get a random value for it...
    /// </summary>
    public static class GetRandom
    {
        /// <summary>
        /// Random Float (user defined min/max, default = 0f, 1f)
        /// </summary>
        public static float Float(float _min = 0f, float _max = 1f)
        {
            return Random.Range(_min, _max);
        }

        
        /// <summary>
        /// Random Int (user defined min/max, default = 0, 1)
        /// </summary>
        public static int Int(int _min = 0, int _max = 1, bool inclusive = true)
        {
            // if ? true : false;
            return inclusive ? Random.Range(_min, _max + 1) : Random.Range(_min, _max);
        }
        
        
        
        public static double Double(double _min = 0f, double _max = 1f)
        {
            return Random.Range((float)_min, (float)_max);
        }


        
        public static int[] Order(int lenght)
        {
            List<int> _order = new List<int>();

            for (int i = 0; i < lenght; i++)
            {
                _order.Add(i);
            }

            var _rand = new System.Random();
            var _newOrder = _order.OrderBy(a => _rand.Next());

            return _newOrder.ToArray();
        }
        
        
        
        /// <summary>
        /// Random Color (0-1)
        /// </summary>
        public static Color Color
        {
            get
            {
                return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            }
        }

        
        /// <summary>
        /// Random Color32 (0-255)
        /// </summary>
        public static Color32 Color32
        {
            get
            {
                return new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
            }
        }

        
        /// <summary>
        /// Random HSV Color (0-255)
        ///   Added In: Detective Notes
        /// </summary>
        public static Color ColorHSV(int defaultH, int defaultS, int defaultV)
        {
            float _floatH = defaultH / 360f;
            float _floatS = defaultS / 100f;
            float _floatV = defaultV / 100f;
            return Color.HSVToRGB(_floatH, _floatS, _floatV);
        }
        
        
        
        /// <summary>
        /// Random Vector2 (user defined min/max)
        /// </summary>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector2 within the min/max defined</returns>
        public static Vector2 Vector2(float min, float max)
        {
            return new Vector2(Random.Range(min, max), Random.Range(min, max));
        }

        
        /// <summary>
        /// Random Vector2 (user defined min/max for each axis)
        /// </summary>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <returns>A random Vector2 within the min/max defined</returns>
        public static Vector2 Vector2(float minX, float maxX, float minY, float maxY)
        {
            return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }

        
        /// <summary>
        /// Random Vector2 (user defined min/max)
        /// </summary>
        /// <param name="org">The Vector2 to edit</param>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector2 Vector2(Vector2 org, float min, float max)
        {
            return new Vector2(Random.Range(org.x - min, org.x + max), Random.Range(min, max));
        }

        
        /// <summary>
        /// Random Vector2 (user defined min/max for each axis)
        /// </summary>
        /// <param name="org">The Vector2 to edit</param>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector2 Vector2(Vector2 org, float minX, float maxX, float minY, float maxY)
        {
            return new Vector2(Random.Range(org.x - minX, org.x + maxX), Random.Range(org.y - minY, org.y + maxY));
        }

        
        /// <summary>
        /// Random Vector3 (user defined min/max)
        /// </summary>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector3 Vector3(float min, float max)
        {
            return new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        }

        
        /// <summary>
        /// Random Vector3 (user defined min/max for each axis)
        /// </summary>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <param name="minZ">The min value an Z coord can be</param>
        /// <param name="maxZ">The max value an Z coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector3 Vector3(float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
        {
            return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        }

        
        /// <summary>
        /// Random Vector3 (user defined min/max)
        /// </summary>
        /// <param name="org">The Vector3 to edit</param>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector3 Vector3(Vector3 org, float min, float max)
        {
            return new Vector3(Random.Range(org.x - min, org.x + max), Random.Range(org.y - min, org.y + max), Random.Range(org.z - min, org.z + max));
        }

        
        /// <summary>
        /// Random Vector3 (user defined min/max for each axis)
        /// </summary>
        /// <param name="org">The Vector3 to edit</param>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <param name="minZ">The min value an Z coord can be</param>
        /// <param name="maxZ">The max value an Z coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector3 Vector3(Vector3 org, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
        {
            return new Vector3(Random.Range(org.x - minX, org.x + maxX), Random.Range(org.y - minY, org.y + maxY), Random.Range(org.z - minZ, org.z + maxZ));
        }

        
        /// <summary>
        /// Random Vector4 (user defined min/max)
        /// </summary>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector4 within the min/max defined</returns>
        public static Vector4 Vector4(float min, float max)
        {
            return new Vector4(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        }

        
        /// <summary>
        /// Random Vector4 (user defined min/max for each axis)
        /// </summary>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <param name="minZ">The min value an Z coord can be</param>
        /// <param name="maxZ">The max value an Z coord can be</param>
        /// <param name="minW">The min value an W coord can be</param>
        /// <param name="maxW">The max value an W coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector4 Vector4(float minX, float maxX, float minY, float maxY, float minZ, float maxZ, float minW, float maxW)
        {
            return new Vector4(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ), Random.Range(minW, maxW));
        }

        
        /// <summary>
        /// Random Vector4 (user defined min/max)
        /// </summary>
        /// <param name="org">The Vector4 to edit</param>
        /// <param name="min">The min value a coord can be</param>
        /// <param name="max">The max value a coord can be</param>
        /// <returns>A random Vector4 within the min/max defined</returns>
        public static Vector4 Vector4(Vector4 org, float min, float max)
        {
            return new Vector4(Random.Range(org.x - min, org.x + max), Random.Range(min, max), Random.Range(org.z - min, org.z + max), Random.Range(org.w - min, org.w + max));
        }

        
        /// <summary>
        /// Random Vector4 (user defined min/max for each axis)
        /// </summary>
        /// <param name="org">The Vector4 to edit</param>
        /// <param name="minX">The min value an X coord can be</param>
        /// <param name="maxX">The max value an X coord can be</param>
        /// <param name="minY">The min value an Y coord can be</param>
        /// <param name="maxY">The max value an Y coord can be</param>
        /// <param name="minZ">The min value an Z coord can be</param>
        /// <param name="maxZ">The max value an Z coord can be</param>
        /// <param name="minW">The min value an W coord can be</param>
        /// <param name="maxW">The max value an W coord can be</param>
        /// <returns>A random Vector3 within the min/max defined</returns>
        public static Vector4 Vector4(Vector4 org, float minX, float maxX, float minY, float maxY, float minZ, float maxZ, float minW, float maxW)
        {
            return new Vector4(Random.Range(org.x - minX, org.x + maxX), Random.Range(org.y - minY, org.y + maxY), Random.Range(org.z - minZ, org.z + maxZ), Random.Range(org.w - minW, org.w + maxW));
        }


        public static T FromList<T>(List<T> list)
        {
            return list[Random.Range(0, list.Count - 1)];
        }
        
        
        public static T FromArray<T>(T[] list)
        {
            return list[Random.Range(0, list.Length - 1)];
        }
    }
}