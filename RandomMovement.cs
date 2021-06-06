using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JTools.GetSet;

namespace JTools
{
    public class RandomMovement : MonoBehaviour
    {
        [SerializeField] private float slowness = 5f;
        [SerializeField] private float variance = 2f;

        private Vector3 startPos;
        private Vector3 randomPos;


        private void OnDisable()
        {
            StopAllCoroutines();
        }


        private void Start()
        {
            startPos = transform.position;
            StartCoroutine(MovementCo());
        }



        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, randomPos, Time.unscaledDeltaTime / slowness);
        }


        private IEnumerator MovementCo()
        {
            randomPos = GetRandom.Vector3(startPos, variance, variance);
            yield return new WaitForSecondsRealtime(GetRandom.Float(2f, 10f));
            StartCoroutine(MovementCo());
        }
    }
}
