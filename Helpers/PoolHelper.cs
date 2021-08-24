using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace JTools
{
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
        /// Disables all objects in the List GameObject pool provided.
        /// </summary>
        /// <param name="pool">Collection of GameObjects | Object pool to use.</param>
        public static void DisableAllInPool(IEnumerable<GameObject> pool)
        {
            foreach (var obj in pool)
                obj.SetActive(false);
        }
        
        

        public static List<GameObject> ExpandPool(List<GameObject> pool, List<GameObject> prefab, Transform parent, int length, bool setActive = false)
        {
            var _list = new List<GameObject>();
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(GetRandom.FromList(prefab), parent);
                _go.SetActive(setActive);
                _list.Add(_go);
            }

            pool.AddRange(_list);
            return pool;
        }
        
        
        
        /// <summary>
        /// Sets up an object pool for use...
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <returns>Array of GameObjects</returns>
        public static GameObject[] SetupArrayPool(GameObject prefab, int length)
        {
            var _array = new GameObject[length];
            
            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab);
                _go.SetActive(false);
                _array[i] = _go;
            }

            return _array;
        }
        
        
        /// <summary>
        /// Sets up an object pool for use...
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="parent">Transform | The parent object to add the pool objects too...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <param name="setActive">Bool | Optional | Should start enabled?</param>
        /// <returns>Array of GameObjects</returns>
        public static GameObject[] SetupArrayPool(GameObject prefab, Transform parent, int length, bool setActive = false)
        {
            var _array = new GameObject[length];
            
            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab, parent);
                _go.SetActive(setActive);
                _array[i] = _go;
            }

            return _array;
        }
        
        
        
        /// <summary>
        /// Sets up a new array of the type defined from an array of GameObjects....
        /// </summary>
        /// <param name="pool">GameObject Array | The array to read from...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <typeparam name="T">T | The type to make the list of...</typeparam>
        /// <returns></returns>
        /// <remarks>Handy when you want to get a component in each object of a collection...</remarks>
        public static T[] SetupArrayPoolFromComponent<T>(GameObject[] pool, int length)
        {
            var _array = new T[length];
            
            for (var i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponent<T>();
                _array[i] = _go;
            }

            return _array;
        }
        
        
        
        /// <summary>
        /// Sets up a new array of the child type defined from an array of GameObjects....
        /// </summary>
        /// <param name="pool">GameObject Array | The array to read from...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <typeparam name="T">T | The type to make the list of...</typeparam>
        /// <returns></returns>
        /// <remarks>Handy when you want to get a child component in each object of a collection...</remarks>
        public static T[] SetupArrayPoolFromChildComponent<T>(GameObject[] pool, int length)
        {
            var _array = new T[length];
            
            for (var i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponentInChildren<T>();
                _array[i] = _go;
            }

            return _array;
        }
        
        
        
        /// <summary>
        /// Sets up an object pool for use...
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <param name="setActive">Bool | Optional | Should start enabled?</param>
        /// <returns>List of GameObjects</returns>
        public static List<GameObject> SetupListPool(GameObject prefab, int length, bool setActive = false)
        {
            var _list = new List<GameObject>();
            
            for (var i = 0; i < length; i++)
            {
                var _go = Object.Instantiate(prefab);
                _go.SetActive(setActive);
                _list.Add(_go);
            }

            return _list;
        }
        
        
        
        /// <summary>
        /// Sets up an object pool for use...
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="parent">Transform | The parent object to add the pool objects too...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <param name="setActive">Bool | Optional | Should start enabled?</param>
        /// <returns></returns>
        public static List<GameObject> SetupListPool(GameObject prefab, Transform parent, int length, bool setActive = false)
        {
            List<GameObject> _list = new List<GameObject>();
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(prefab, parent);
                _go.SetActive(setActive);
                _list.Add(_go);
            }

            return _list;
        }


        
        /// <summary>
        /// Sets up a new array of the type defined from an array of GameObjects....
        /// </summary>
        /// <param name="pool">GameObject List | The array to read from...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <typeparam name="T">T | The type to make the list of...</typeparam>
        /// <returns></returns>
        /// <remarks>Handy when you want to get a component in each object of a collection...</remarks>
        public static List<T> SetupListPoolFromComponent<T>(List<GameObject> pool, int length)
        {
            var _array = new List<T>();
            
            for (var i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponent<T>();
                _array.Add(_go);
            }

            return _array;
        }
        
        
        
        /// <summary>
        /// Sets up a new array of the child type defined from an array of GameObjects....
        /// </summary>
        /// <param name="pool">GameObject List | The array to read from...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <typeparam name="T">T | The type to make the list of...</typeparam>
        /// <returns></returns>
        /// <remarks>Handy when you want to get a child component in each object of a collection...</remarks>
        public static List<T> SetupListPoolFromChildComponent<T>(List<GameObject> pool, int length)
        {
            var _array = new List<T>();
            
            for (var i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponentInChildren<T>();
                _array.Add(_go);
            }

            return _array;
        }
        
        

        /// <summary>
        /// Makes a new object from the prefab that is ready to be added to a pool....
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="parent">Transform | The parent object to add the pool objects too...</param>
        /// <returns></returns>
        public static GameObject SetupNewItemInPool(GameObject prefab, Transform parent)
        {
            var _go = Object.Instantiate(prefab, parent);
            _go.SetActive(false);
            return _go;
        }
        
        
        
        /// <summary>
        /// Sets up an object pool for use...
        /// </summary>
        /// <param name="prefab">GameObject | The prefab to add to the pool...</param>
        /// <param name="parent">Transform | The parent object to add the pool objects too...</param>
        /// <param name="length">Int | The amount of objects you want in this pool...</param>
        /// <param name="setActive">Bool | Optional | Should start enabled?</param>
        /// <returns></returns>
        public static List<GameObject> SetupListPool(List<GameObject> prefab, Transform parent, int length, bool setActive = false)
        {
            List<GameObject> _list = new List<GameObject>();
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(GetRandom.FromList(prefab), parent);
                _go.SetActive(setActive);
                _list.Add(_go);
            }

            return _list;
        }
    }
}
