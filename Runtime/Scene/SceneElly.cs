using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JTools
{
    public static class SceneElly
    {
        /// <summary>
        /// Gets any and all of the type requested from the active scene...
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>List of any instances of the type found in the scene</returns>
        public static List<T> GetComponentsFromScene<T>()
        {
            var _objects = new List<GameObject>();
            var _scene = SceneManager.GetActiveScene();
            var _validObjectsFromScene = new List<T>();
            
            _scene.GetRootGameObjects(_objects);
            
            foreach (var _go in _objects)
                _validObjectsFromScene.AddRange(_go.GetComponentsInChildren<T>(true));

            return _validObjectsFromScene;
        }


        /// <summary>
        /// Gets any and all of the type requested from the scene requested...
        /// </summary>
        /// <param name="s">The scene to search</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>List of any instances of the type found in the scene</returns>
        /// <returns></returns>
        public static List<T> GetComponentsFromScene<T>(Scene s)
        {
            var _objects = new List<GameObject>();
            var _scene = s;
            var _validObjectsFromScene = new List<T>();
            
            _scene.GetRootGameObjects(_objects);
            
            foreach (var _go in _objects)
                _validObjectsFromScene.AddRange(_go.GetComponentsInChildren<T>(true));

            return _validObjectsFromScene;
        }
        
        
        /// <summary>
        /// Gets any and all of the type requested from the scene requested...
        /// </summary>
        /// <param name="s">The scenes to search</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>List of any instances of the type found in the scene</returns>
        /// <returns></returns>
        public static List<T> GetComponentsFromScenes<T>(List<Scene> s)
        {
            var _objects = new List<GameObject>();
            var _validObjectsFromScene = new List<T>();

            foreach (var _scene in s)
            {
                _scene.GetRootGameObjects(_objects);
                foreach (var _go in _objects)
                    _validObjectsFromScene.AddRange(_go.GetComponentsInChildren<T>(true));
            }

            return _validObjectsFromScene;
        }


        /// <summary>
        /// Gets the first of any and all of the type requested from the active scene...
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>First instance of the type found in the active scene</returns>
        public static T GetComponentFromScene<T>()
        {
            var _allOfType = GetComponentsFromScene<T>();

            return _allOfType.Count > 0 
                ? _allOfType[0] 
                : default;
        }
        
        
        /// <summary>
        /// Gets the first of any and all of the type requested from the scene requested...
        /// </summary>
        /// <param name="s">The scene to search</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>First instance of the type found in the scene provided</returns>
        public static T GetComponentFromScene<T>(Scene s)
        {
            var _allOfType = GetComponentsFromScene<T>(s);

            return _allOfType.Count > 0 
                ? _allOfType[0] 
                : default;
        }
        
        
        /// <summary>
        /// Gets the first of any and all of the type requested from the active scenes requested...
        /// </summary>
        /// <param name="s">The scene to search</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>First instance of the type found in any of the scenes provided</returns>
        public static T GetComponentFromScenes<T>(List<Scene> s)
        {
            var _allOfType = GetComponentsFromScenes<T>(s);

            return _allOfType.Count > 0 
                ? _allOfType[0] 
                : default;
        }
    }
}