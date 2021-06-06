using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools
{
    public static class Pool
    {
        /// <summary>
        /// Gets the first free object in a List GameObject pool.
        /// </summary>
        /// <param name="pool">List of GameObjects | Object pool to use.</param>
        /// <returns>GameObject | The first free GameObject in the pool provided.</returns>
        public static GameObject GetFirstObjectFree(List<GameObject> pool)
        {
            for (int i = 0; i < pool.Count; i++)
            {
                if (!pool[i].activeInHierarchy)
                    return pool[i];
            }

            return null;
        }
        
        
        public static GameObject GetFirstObjectFree(GameObject[] pool)
        {
            for (int i = 0; i < pool.Length; i++)
            {
                if (!pool[i].activeInHierarchy)
                    return pool[i];
            }

            return null;
        }


        public static void DisableAllInPool(List<GameObject> pool)
        {
            for (int i = 0; i < pool.Count; i++)
                pool[i].SetActive(false);
        }
        
        public static void DisableAllInPool(GameObject[] pool)
        {
            for (int i = 0; i < pool.Length; i++)
                pool[i].SetActive(false);
        }


        public static GameObject[] SetupArrayPool(GameObject prefab, int length)
        {
            GameObject[] _array = new GameObject[length];
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(prefab);
                _go.SetActive(false);
                _array[i] = _go;
            }

            return _array;
        }
        
        
        public static GameObject[] SetupArrayPool(GameObject prefab, Transform parent, int length)
        {
            GameObject[] _array = new GameObject[length];
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(prefab, parent);
                _go.SetActive(false);
                _array[i] = _go;
            }

            return _array;
        }
        
        
        public static T[] SetupArrayPoolFromPoolComponent<T>(GameObject[] pool, int length)
        {
            T[] _array = new T[length];
            
            for (int i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponent<T>();
                _array[i] = _go;
            }

            return _array;
        }
        
        
        public static T[] SetupArrayPoolFromPoolChildComponent<T>(GameObject[] pool, int length)
        {
            T[] _array = new T[length];
            
            for (int i = 0; i < length; i++)
            {
                var _go = pool[i].GetComponentInChildren<T>();
                _array[i] = _go;
            }

            return _array;
        }
        
        
        public static List<GameObject> SetupListPool(GameObject prefab, int length)
        {
            List<GameObject> _list = new List<GameObject>();
            
            for (int i = 0; i < length; i++)
            {
                GameObject _go = Object.Instantiate(prefab);
                _go.SetActive(false);
                _list.Add(_go);
            }

            return _list;
        }
        
        
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



        public static GameObject SetupNewItemInPool(GameObject prefab, Transform parent)
        {
            GameObject _go = Object.Instantiate(prefab, parent);
            _go.SetActive(false);
            return _go;
        }
    }
}
