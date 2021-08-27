using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools
{
    public static class DeepCopy
    {
        /// <summary>
        /// Deep copies an object of any type...
        /// </summary>
        /// <param name="toCopy">The object to copy</param>
        /// <typeparam name="T">Generic type (gets the type to copy)</typeparam>
        /// <returns>A Deep Copy of the entered object...</returns>
        public static T DeepCopyObject<T>(T toCopy) where T : new()
        {
            var _l = new T();
            _l = default(T);
            _l = toCopy;
            return _l;
        }
        
        
        
        /// <summary>
        /// Makes a deep copy of the list entered...
        /// </summary>
        /// <param name="toCopy">The list to copy</param>
        /// <typeparam name="T">Generic type (gets the type to copy)</typeparam>
        /// <returns>A Deep Copy of the entered list...</returns>
        public static List<T> DeepCopyList<T>(List<T> toCopy) where T : new()
        {
            var _l = new List<T>();

            for (int i = 0; i < toCopy.Count; i++)
            {
                _l.Add(toCopy[i]);
            }

            return _l;
        }
        
        
        
        /// <summary>
        /// Makes a deep copy of the array entered...
        /// </summary>
        /// <param name="toCopy">The array to copy</param>
        /// <typeparam name="T">Generic type (gets the type to copy)</typeparam>
        /// <returns>A Deep Copy of the entered array...</returns>
        public static T[] DeepCopyArray<T>(T[] toCopy)
        {
            var _l = new T[toCopy.Length];

            for (int i = 0; i < toCopy.Length; i++)
            {
                _l[i] = default(T);
                _l[i] = toCopy[i];
            }

            return _l;
        }
    }
}
