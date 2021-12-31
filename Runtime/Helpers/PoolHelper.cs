using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace JTools
{
    /// <summary>
    /// A collection of methods to help with object pooling
    /// </summary>
    public static class PoolHelper
    {
        /// <summary>
        /// Gets the first free object in a List GameObject pool.
        /// </summary>
        /// <param name="pool">Collection of GameObjects | Object pool to use.</param>
        /// <returns>GameObject | The first free GameObject in the pool provided.</returns>
        public static GameObject GetFirstObjectFree(IEnumerable<GameObject> pool)
        {
            return pool.FirstOrDefault(t => !t.activeInHierarchy);
        }
        
        
        /// <summary>
        /// Checks to see if there are any free objects in the pool provided...
        /// </summary>
        /// <param name="pool">Collection of GameObjects | Object pool to use.</param>
        /// <returns>True or False</returns>
        public static bool HasFreeObject(IEnumerable<GameObject> pool)
        {
            return pool.Any(t => !t.activeInHierarchy);
        }
        

        /// <summary>
        /// Disables all objects in the pool entered...
        /// </summary>
        /// <param name="pool"></param>
        public static void DisableAllInPool(List<GameObject> pool)
        {
            foreach (var obj in pool)
                obj.SetActive(false);
        }


        /// <summary>
        /// Enables all objects in the pool entered...
        /// </summary>
        /// <param name="pool"></param>
        public static void EnableAllInPool(List<GameObject> pool)
        {
            foreach (var obj in pool)
                obj.SetActive(true);
        }


        /// <summary>
        /// Expands the object pool entered and returns the result...
        /// </summary>
        /// <param name="pool">The pool to edit</param>
        /// <param name="prefab">The prefab or random from a list of prefabs</param>
        /// <param name="parent">The to assign the object too</param>
        /// <param name="setActive">How the prefabs be set to</param>
        /// <returns>The expanded pool</returns>
        public static List<GameObject> ExpandPool(List<GameObject> pool, List<GameObject> prefab, Transform parent, bool setActive = false)
        {
            var _list = new List<GameObject>();
            
            for (var i = 0; i < prefab.Count; i++)
            {
                GameObject _go = Object.Instantiate(GetRandom.FromList(prefab), parent);
                _go.SetActive(setActive);
                _list.Add(_go);
            }

            pool.AddRange(_list);
            return pool;
        }
        

        /// <summary>
        /// Sets up the object pool entered and returns the result...
        /// </summary>
        /// <param name="prefab">The prefab to use</param>
        /// <param name="length">The amount of objects to spawn</param>
        /// <param name="pool">The pool to edit</param>
        public static void SetupObjectPool(GameObject prefab, int length, out List<GameObject> pool)
        {
            var _pool = new List<GameObject>();

            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab);
                _go.SetActive(false);
                _pool.Add(_go);
            }

            pool = _pool;
        }
        
        
        /// <summary>
        /// Sets up the object pool entered and outs the result...
        /// </summary>
        /// <param name="prefab">The prefab to use</param>
        /// <param name="parent">The parent to set the objects to</param>
        /// <param name="length">The amount of objects to spawn</param>
        /// <param name="pool">The pool to edit</param>
        public static void SetupObjectPool(GameObject prefab, Transform parent, int length, out List<GameObject> pool)
        {
            var _pool = new List<GameObject>();

            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab, parent);
                _go.SetActive(false);
                _pool.Add(_go);
            }

            pool = _pool;
        }
        
        
        /// <summary>
        /// Sets up the object pool entered and outs the result...
        /// </summary>
        /// <param name="prefab">The prefab to use</param>
        /// <param name="parent">The parent to set the objects to</param>
        /// <param name="length">The amount of objects to spawn</param>
        /// <param name="setActive">How the prefabs be set to</param>
        /// <param name="pool">The pool to edit</param>
        public static void SetupObjectPool(GameObject prefab, Transform parent, int length, bool setActive, out List<GameObject> pool)
        {
            var _pool = new List<GameObject>();

            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab, parent);
                _go.SetActive(setActive);
                _pool.Add(_go);
            }

            pool = _pool;
        }


        /// <summary>
        /// Sets up an object pool with a children component of the entered list of GameObjects and outs the result...
        /// </summary>
        /// <param name="pool">The objects to get the component from</param>
        /// <param name="length">The length of the pool</param>
        /// <param name="outPool">The result</param>
        /// <typeparam name="T">The type to find</typeparam>
        public static void SetupObjectPoolFromChildren<T>(List<GameObject> pool, int length, out List<T> outPool)
        {
            var _pool = new List<T>();
            
            for (var i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponent<T>();
                _pool.Add(_go);
            }

            outPool = _pool;
        }
        
        
        /// <summary>
        /// Makes a new object from the prefab that is ready to be added to a pool....
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="parent">Transform | The parent object to add the pool objects too...</param>
        /// <returns></returns>
        public static void SetupNewItemInPool(GameObject prefab, Transform parent, List<GameObject> pool, out List<GameObject> _updatedPool)
        {
            var _go = Object.Instantiate(prefab, parent);
            _go.SetActive(false);
            pool.Add(_go);
            _updatedPool = pool;
        }
    }
}
