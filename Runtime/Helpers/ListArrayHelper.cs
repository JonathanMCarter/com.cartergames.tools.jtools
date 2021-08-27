using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;

namespace JTools
{
    public static class ListArrayHelper
    {
        /// <summary>
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        public static void EnableAllGameObjects(IEnumerable<GameObject> buttons)
        {
            foreach (var _v in buttons)
            {
                if (!_v.gameObject.activeInHierarchy)
                    _v.gameObject.SetActive(true);
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
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        public static void EnableAllButtons(Button[] buttons)
        {
            foreach (var _v in buttons)
            {
                if (!_v.gameObject.activeInHierarchy)
                    _v.gameObject.SetActive(true);
                
                _v.interactable = true;
            }
        }
        
        
        
        /// <summary>
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="toIgnore">Int[] | Elements to ignore...</param>
        public static void EnableAllButtonsBar(Button[] buttons, int[] toIgnore)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (ArrayContains(toIgnore, i)) continue;
                
                if (!buttons[i].gameObject.activeInHierarchy)
                    buttons[i].gameObject.SetActive(true);

                buttons[i].interactable = true;
            }
        }
        
        
        
        /// <summary>
        /// Enables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="toUse">Int[] | Elements to ignore...</param>
        public static void EnableSelectiveButtons(Button[] buttons, int[] toUse)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (!ArrayContains(toUse, i)) continue;
                
                if (!buttons[i].gameObject.activeInHierarchy)
                    buttons[i].gameObject.SetActive(true);

                buttons[i].interactable = true;
            }
        }
        
        
        
        /// <summary>
        /// Disables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="disableObject">Bool | should disable object...</param>
        public static void DisableAllButtons(Button[] buttons, bool disableObject = false)
        {
            foreach (var _v in buttons)
            {
                if (!disableObject)
                    _v.interactable = false;
                else
                    _v.gameObject.SetActive(false);
            }
        }
        
        
        
        /// <summary>
        /// Disables all the items in the Button Array entered....except the ones that are to be ignored...
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="toIgnore">Int[] | Elements to ignore...</param>
        /// <param name="disableObject">Bool | should disable object...</param>
        public static void DisableAllButtonsBar(Button[] buttons, int[] toIgnore, bool disableObject = false)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (ArrayContains(toIgnore, i)) continue;
                
                if (!disableObject)
                    buttons[i].interactable = false;
                else
                    buttons[i].gameObject.SetActive(false);
            }
        }
        
        
        
        
        /// <summary>
        /// Disables the selected the items in the Button Array entered only.... 
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="toUse">Int[] | Elements to ignore...</param>
        /// <param name="disableObject">Bool | should disable object...</param>
        public static void DisableSelectiveButtons(Button[] buttons, int[] toUse, bool disableObject = false)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (!ArrayContains(toUse, i)) continue;
                
                if (!disableObject)
                    buttons[i].interactable = false;
                else
                    buttons[i].gameObject.SetActive(false);
            }
        }
        
        
        
        
        /// <summary>
        /// Disables the selected the items in the Button Array entered only.... 
        /// </summary>
        /// <param name="obj">Button[] | To Edit...</param>
        /// <param name="toUse">Int[] | Elements to ignore...</param>
        /// <param name="disableObject">Bool | should disable object...</param>
        public static void DisableSelective(List<GameObject> obj, int[] toDisable)
        {
            for (var i = 0; i < obj.Count; i++)
            {
                if (ArrayContains(toDisable, i)) continue;
                obj[i].gameObject.SetActive(false);
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(toFind))
                    return true;
            }
            
            return false;
        }
        
        
        
        
        /// <summary>
        /// Disables all the items in the Button Array entered....
        /// </summary>
        /// <param name="buttons">Button[] | To Edit...</param>
        /// <param name="disableObject">Bool | should disable object...</param>
        public static void DisableAllCanvases(Canvas[] buttons, bool disableObject = false)
        {
            foreach (var _v in buttons)
            {
                if (!disableObject)
                    _v.enabled = false;
                else
                    _v.gameObject.SetActive(false);
            }
        }


        
        public static int Sum(List<int> list)
        {
            return list.Sum();
        }



        public static List<T> SortHighestFirst<T>(List<T> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
        
        
        public static T[] SortHighestFirst<T>(T[] array)
        {
            var _list = array.ToList();
            _list.Sort();
            _list.Reverse();
            return _list.ToArray();
        }



        public static T[] RemoveFromArray<T>(T[] array, T toRemove)
        {
            var _list = array.ToList();
            _list.Remove(toRemove);
            return _list.ToArray();
        }
    }
}