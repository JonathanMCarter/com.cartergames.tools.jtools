using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools
{
    public class RandomRotation : MonoBehaviour
    {
        [SerializeField] private float slowness = 5f;
        [SerializeField] private float variance = 2f;

        private Quaternion startRot;
        private Quaternion randomRot;


        private void OnDisable()
        {
            StopAllCoroutines();
        }


        private void Start()
        {
            startRot = transform.localRotation;
            StartCoroutine(MovementCo());
        }



        private void Update()
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, randomRot, Time.unscaledDeltaTime / slowness);
        }


        private IEnumerator MovementCo()
        {
            randomRot = Quaternion.Euler(GetRandom.Vector3(startRot.eulerAngles, variance, variance));
            yield return new WaitForSecondsRealtime(GetRandom.Float(2f, 10f));
            StartCoroutine(MovementCo());
        }
    }
}
