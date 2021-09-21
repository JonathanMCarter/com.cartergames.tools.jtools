using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace JTools
{
    /// <summary>
    /// Just like the TryGetComponent, but with options to get from parents and children.
    /// </summary>
    public static class TryGet
    {
        /// <summary>
        /// Tries to get the component requested in the parent(s) of the GameObject entered...
        /// </summary>
        /// <param name="target">The GameObject to target</param>
        /// <param name="component">The component found</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>Bool with the component</returns>
        public static bool ComponentInParent<T>(GameObject target, out T component)
        {
            var _check = target.GetComponentInParent<T>();
            component = _check;
            return _check != null;
        }
        
        
        /// <summary>
        /// Tries to get the components requested in the parent(s) of the GameObject entered...
        /// </summary>
        /// <param name="target">The GameObject to target</param>
        /// <param name="component">The components found</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>Bool with the components list</returns>
        public static bool ComponentsInParent<T>(GameObject target, out List<T> component)
        {
            var _check = target.GetComponentsInParent<T>().ToList();
            component = _check;
            return _check.Count > 0;
        }
        
        
        /// <summary>
        /// Tries to get the component requested in the children(s) of the GameObject entered...
        /// </summary>
        /// <param name="target">The GameObject to target</param>
        /// <param name="component">The component found</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>Bool with the component</returns>
        public static bool ComponentInChildren<T>(GameObject target, out T component)
        {
            var _check = target.GetComponentInChildren<T>();
            component = _check;
            return _check != null;
        }
        
        
        /// <summary>
        /// Tries to get the components requested in the children(s) of the GameObject entered...
        /// </summary>
        /// <param name="target">The GameObject to target</param>
        /// <param name="component">The components found</param>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns>Bool with the components list</returns>
        public static bool ComponentsInChildren<T>(GameObject target, out List<T> component)
        {
            var _check = target.GetComponentsInChildren<T>().ToList();
            component = _check;
            return _check.Count > 0;
        }
    }
}