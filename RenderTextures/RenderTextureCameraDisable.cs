using UnityEngine;

namespace JTools.RenderTextures
{
    /// <summary>
    /// Disables the camera this is attached to when the render textures have been setup...
    /// </summary>
    public class RenderTextureCameraDisable : MonoBehaviour
    {
        private Camera cam;

        /// <summary>
        /// Gets the camera for use...
        /// </summary>
        public Camera GetCamera => cam;

        
        private void OnEnable()
        {
            if (!cam)
                cam = GetComponent<Camera>();
        }


        /// <summary>
        /// Disables the camera on call...
        /// </summary>
        internal void DisableCamera() => cam.enabled = false;
    }
}
