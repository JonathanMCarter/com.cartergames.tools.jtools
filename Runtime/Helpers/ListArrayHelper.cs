using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;

namespace JTools
{
    public static class ListArrayHelper
    {
        /// <summary>
        /// Initialises the list if it is not already
        /// </summary>
        /// <param name="list">The list to edit</param>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <returns>A initalised list</returns>
        public static List<T> InitialiseIfNull<T>(List<T> list)
        {
            if (list == null)
            {
                Debug.Log("Null List");
                return new List<T>();
            }
            
            if (list.Count.Equals(0))
            {
                Debug.Log("0 Count List");
                return new List<T>();
            }

            return list;
        }
        
        
        /// <summary>
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="objects">Button[] | To Edit...</param>
        public static void EnableAllGameObjects(IEnumerable<GameObject> objects)
        {
            foreach (var obj in objects)
            {
                if (!obj.gameObject.activeInHierarchy)
                    obj.gameObject.SetActive(true);
            }
        }
        
        
        /// <summary>
        /// Enables all the items in the Canvas Array entered....
        /// </summary>
        /// <param name="canvases">Button[] | To Edit...</param>
        public static void EnableAllCanvases(IEnumerable<Canvas> canvases)
        {
            foreach (var canvas in canvases)
            {
                if (!canvas.enabled)
                    canvas.enabled = true;
            }
        }
        
        
        /// <summary>
        /// Enables all the items in the Canvas Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        public static void EnableAllButtons(IEnumerable<Button> buttons)
        {
            foreach (var btn in buttons)
            {
                if (!btn.enabled)
                    btn.enabled = true;
            }
        }
        
        
        /// <summary>
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="objects">Button[] | To Edit...</param>
        public static void DisableAllGameObjects(IEnumerable<GameObject> objects)
        {
            foreach (var obj in objects)
            {
                if (obj.gameObject.activeInHierarchy)
                    obj.gameObject.SetActive(false);
            }
        }
        
        
        /// <summary>
        /// Enables all the items in the Canvas Array entered....
        /// </summary>
        /// <param name="canvases">Button[] | To Edit...</param>
        public static void DisableAllCanvases(IEnumerable<Canvas> canvases)
        {
            foreach (var canvas in canvases)
            {
                if (canvas.enabled)
                    canvas.enabled = false;
            }
        }
        
        
        /// <summary>
        /// Enables all the items in the Canvas Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        public static void DisableAllButtons(IEnumerable<Button> buttons)
        {
            foreach (var btn in buttons)
            {
                if (btn.enabled)
                    btn.enabled = false;
            }
        }
        

        /// <summary>
        /// Returns whether or not an item is in the array entered...
        /// </summary>
        /// <param name="array">T[] | To Check</param>
        /// <param name="toFind">T | To Find</param>
        /// <typeparam name="T">T | Type</typeparam>
        /// <returns>Bool</returns>
        public static bool ArrayContains<T>(T[] array, T toFind)
        {
            return array.Contains(toFind);
        }


        /// <summary>
        /// Removes an element from an array.
        /// </summary>
        /// <param name="array">The array to edit</param>
        /// <param name="toRemove">The element to remove</param>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <returns>The array without the element entered.</returns>
        public static T[] RemoveFromArray<T>(T[] array, T toRemove)
        {
            var _list = array.ToList();
            _list.Remove(toRemove);
            return _list.ToArray();
        }
    }
}
