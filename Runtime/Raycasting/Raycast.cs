using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace JTools
{
    public static class Raycast
    {
        /// <summary>
        /// Checks to see if the user had hit any UI element with the mouse....
                 /// </summary>
                 /// <returns>Bool</returns>
                 public static bool UIRaycastAllPC(int id = -1)
                 {
                     //Create the PointerEventData with null for the EventSystem
                     var _ped = new PointerEventData(null) { position = Input.mousePosition };
                     //Create list to receive all results
                     var _results = new List<RaycastResult>();
                     //Raycast it
                     EventSystem.current.RaycastAll(_ped, _results);
         
                     // return what was found.
                     return _results.Count > 0 || EventSystem.current.IsPointerOverGameObject(id);
                 }
        
        
        
        /// <summary>
        /// Checks to see if the user has tapped any UI element on a mobile device...
        /// </summary>
        /// <returns>Bool</returns>
        public static bool UIRaycastAllMobile()
        {
            //Create the PointerEventData with null for the EventSystem
            var _ped = new PointerEventData(null) { position = Input.mousePosition };
            //Create list to receive all results
            var _results = new List<RaycastResult>();
            //Raycast it
            EventSystem.current.RaycastAll(_ped, _results);

            // return what was found.
            return _results.Count > 0 || EventSystem.current.IsPointerOverGameObject(1);
        }
        
        
        
        /// <summary>
        /// Checks to see if the user has tapped any UI element on a mobile device...
        /// </summary>
        /// <returns>Bool</returns>
        public static List<RaycastResult> UIRaycastAllMobileWithResults()
        {
            //Create the PointerEventData with null for the EventSystem
            var _ped = new PointerEventData(null) { position = Input.mousePosition };
            //Create list to receive all results
            var _results = new List<RaycastResult>();
            //Raycast it
            EventSystem.current.RaycastAll(_ped, _results);

            // return what was found.
            return !EventSystem.current.IsPointerOverGameObject(1) ? _results : null;
        }
        
        
        
        /// <summary>
        /// Raycasts UI and returns what it gets.
        /// </summary>
        /// <returns>A List of RaycastResults.</returns>
        public static List<RaycastResult> UIRaycast(GraphicRaycaster gr)
        {
            // grabbed the code form an old project xD.
            //Code to be place in a MonoBehaviour with a GraphicRaycaster component
            var _gr = gr;
            //Create the PointerEventData with null for the EventSystem
            var _ped = new PointerEventData(null) { position = Input.mousePosition };
            //Create list to receive all results
            var _results = new List<RaycastResult>();
            //Raycast it
            _gr.Raycast(_ped, _results);
            
            // return what was found.
            return _results.Count > 0 ? _results : null;
        }
        
        
        
        /// <summary>
        /// Raycasts All UI in the scene and returns if the user hit any....
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Note this is not 100% effective, its recommended to use PC or Mobile variants...
        /// </remarks>
        public static bool UIRaycastAll()
        {
            //Create the PointerEventData with null for the EventSystem
            var _ped = new PointerEventData(null) { position = Input.mousePosition };
            //Create list to receive all results
            var _results = new List<RaycastResult>();
            //Raycast it
            EventSystem.current.RaycastAll(_ped, _results);

            // return what was found.
            return _results.Count > 0;
        }



        /// <summary>
        /// Raycasts UI and returns what it gets.
        /// </summary>
        /// <returns>A List of RaycastResults.</returns>
        public static List<RaycastResult> MultiUIRaycast(GraphicRaycaster[] gr)
        {
            var _results = new List<RaycastResult>();

            //Create the PointerEventData with null for the EventSystem
            var _ped = new PointerEventData(null) { position = Input.mousePosition };

            for (int i = 0; i < gr.Length; i++)
            {
                var _tempResults = new List<RaycastResult>();

                // grabbed the code form an old project xD.
                //Code to be place in a MonoBehaviour with a GraphicRaycaster component
                var _gr = gr[i];

                //Raycast it
                _gr.Raycast(_ped, _tempResults);
                _results.AddRange(_tempResults);
            }

            // return what was found.
            return _results.Count > 0 ? _results : null;
        }
        
        
        
        /// <summary>
        /// Raycast 3D Objects.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// </summary>
        /// <param name="a">Ray | The ray to check.</param>
        /// <param name="mask">LayerMask | The layer to check for.</param>
        /// <param name="distance">Float | The distance from the origin the ray should travel. Default is Mathf.Infinity</param>
        /// <returns>RaycastHit | The hit object, it will be null collider if there was no hit.</returns>
        public static RaycastHit Raycast3D(Ray a, LayerMask mask, float distance = Mathf.Infinity)
        {
            Ray _ray = a;
            RaycastHit _hit;

            if (Physics.Raycast(_ray, out _hit, distance, mask))
                return _hit;

            return _hit;
        }
        
        
        /// <summary>
        /// Raycast 3D Objects.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// </summary>
        /// <param name="a">Ray | The ray to check.</param>
        /// <returns>RaycastHit | The hit object, it will be null collider if there was no hit.</returns>
        public static RaycastHit Raycast3D(Ray a)
        {
            Ray _ray = a;
            RaycastHit _hit;

            if (Physics.Raycast(_ray, out _hit, Mathf.Infinity))
                return _hit;

            return _hit;
        }
        


        /// <summary>
        /// Raycast 2D Objects.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// </summary>
        /// <param name="a">Ray2D | The ray to check.</param>
        /// <returns>RaycastHit2D | The hit object, it will be null collider if there was no hit.</returns>
        public static RaycastHit2D Raycast2D(Vector2 org, Vector2 dir)
        {
            return Physics2D.Raycast(org, dir, Mathf.Infinity);
        }
        
        

        /// <summary>
        /// Raycast 2D Objects.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// </summary>
        /// <param name="a">Ray2D | The ray to check.</param>
        /// <returns>RaycastHit2D | The hit object, it will be null collider if there was no hit.</returns>
        public static RaycastHit2D Raycast2D(Vector2 org, Vector2 dir, LayerMask mask)
        {
            return Physics2D.Raycast(org, dir, Mathf.Infinity, 1 << mask);
        }
        


        /// <summary>
        /// Raycast 3D Objects within a sphere of the ray.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// Radius is the size of the sphere used in the sphere cast.
        /// </summary>
        /// <param name="a">Ray | The ray to check.</param>
        /// <param name="rad">Float | The radius of the sphere.</param>
        /// <param name="mask">LayerMask | The layer to check for.</param>
        /// <returns>RaycastHit | The hit object, it will be null collider if there was no hit.</returns>
        public static RaycastHit Raycast3DWithSphere(Ray a, float rad, LayerMask mask)
        {
            RaycastHit _hit;

            if (Physics.SphereCast(a.origin, rad, a.direction, out _hit, Mathf.Infinity, mask))
                return _hit;

            return _hit;
        }
        
        
        
        /// <summary>
        /// Raycast Multiple 3D Objects within a sphere of the ray.
        /// Ray should be a Camera.ScreenPointToRay of the mouse position or similar.
        /// Radius is the size of the sphere used in the sphere cast.
        /// </summary>
        /// <param name="a">Ray | The ray to check.</param>
        /// <param name="rad">Float | The radius of the sphere.</param>
        /// <param name="mask">LayerMask | The layer to check for.</param>
        /// <returns>RaycastHit Array | The hit objects, it will be null collider if there was no hits.</returns>
        public static RaycastHit[] Raycast3DMultiWithSphere(Ray a, float rad, LayerMask mask)
        {
            return (Physics.SphereCastAll(a.origin, rad, a.direction, Mathf.Infinity, mask));
        }
    }
}
