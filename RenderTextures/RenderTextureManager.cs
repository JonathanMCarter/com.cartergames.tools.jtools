using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.RenderTextures
{
    public class RenderTextureManager : MonoBehaviour
    {
        [SerializeField] private List<RenderTexture> texturesToSet;
        [SerializeField] private List<GameObject> renderTextureObjects;

        private RenderTextureCameraDisable camToUse;
        private Camera cam;
        private WaitForSeconds wait;

        
        /// <summary>
        /// Action that gets called when the render texture setup is completed or cycled...
        /// </summary>
        public static event Action OnTextureSetupComplete;

        
        private void Start()
        {
            camToUse = FindObjectOfType<RenderTextureCameraDisable>();
            cam = camToUse.GetCamera;
            wait = new WaitForSeconds(1f);
            StartCoroutine(CycleObjects());
        }
        
        
        /// <summary>
        /// Goes through all objects that need rendering and takes a peek at them to set the textures up...
        /// </summary>
        private IEnumerator CycleObjects()
        {
            for (var i = 0; i < renderTextureObjects.Count; i++)
            {
                renderTextureObjects[i].SetActive(true);
                cam.targetTexture = texturesToSet[i];
                cam.Render();
                yield return new WaitForEndOfFrame();
                cam.targetTexture = null;
                renderTextureObjects[i].SetActive(false);
            }
            
            yield return wait;
            OnTextureSetupComplete?.Invoke();
            camToUse.DisableCamera();
        }


        /// <summary>
        /// Recycles the render textures when called
        /// </summary>
        public void RefreshAllRenderTextures() => StartCoroutine(CycleObjects());
    }
}
