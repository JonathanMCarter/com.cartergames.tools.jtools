using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.RenderTextures
{
    public class RenderTextureManager : MonoBehaviour
    {
        private WaitForSeconds wait;

        public Action OnSetupComplete = null;


        private void Start()
        {
            wait = new WaitForSeconds(1f);
            StartCoroutine(CycleObjects());
        }



        private IEnumerator CycleObjects()
        {
            yield return wait;
            OnSetupComplete?.Invoke();
        }
    }
}
