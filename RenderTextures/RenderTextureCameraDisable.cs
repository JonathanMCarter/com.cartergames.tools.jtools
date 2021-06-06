using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.RenderTextures
{
    public class RenderTextureCameraDisable : MonoBehaviour
    {
        private Camera cam;


        private void OnEnable()
        {
            if (!cam)
                cam = GetComponent<Camera>();

            StartCoroutine(WaitAndDisable());
        }


        private void OnDisable()
        {
            StopAllCoroutines();
        }


        private IEnumerator WaitAndDisable()
        {
            yield return new WaitForEndOfFrame();
            cam.enabled = false;
        }


        public void UpdateRenderTexture()
        {
            StartCoroutine(WaitAndDisable());
        }
    }
}
