using System.Collections;
using UnityEngine;

/****************************************************************************************************************************
 * 
 *  --{   Carter Games Utilities Script   }--
 *							  
 *  Despawner
 *	    Automatically despawns an object after a set time either via disable or destory.
 *			
 *  Written by:
 *      Jonathan Carter
 *      E: jonathan@carter.games
 *      W: https://jonathan.carter.games
 *			        
 *	Last Updated: 18/12/2020 (d/m/y)						
 * 
****************************************************************************************************************************/

namespace CarterGames.Utilities
{
    /// <summary>
    /// Class | Despawns the object it is attached to.
    /// </summary>
    public class Despawner : MonoBehaviour
    {
        /// <summary>
        /// Enum | The choices for the despawner to use.
        /// </summary>
        private enum DespawnerChoices { Disable, Destroy };

        /// <summary>
        /// Float | defines how long the object has before it is removed.
        /// </summary>
        [Header("Despawn Delay")]
        [Tooltip("Set this to define how long the object will wait before despawning. Default Value = 1")]
        [SerializeField] private float despawnTime = 1f;

        /// <summary>
        /// DespawnerChoice | the option to run when the timer runs out.
        /// </summary>
        [Header("Despawn Choice")]
        [Tooltip("Pick an option for what happens when the despawn timer runer out.")]
        [SerializeField] private DespawnerChoices choices;


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Unity OnEnable | When the object is enabled, start the corutine that will despawn the object.
        /// </summary>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void OnEnable()
        {
            StartCoroutine(DespawnCo());
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Unity OnDisable | When the object is disabled, stop all corutines so it doesn't run more than it needs to.
        /// </summary>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void OnDisable()
        {
            StopAllCoroutines();
        }


        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Coroutine | Despawns the object this is attached to as and when it is enabled.
        /// </summary>
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private IEnumerator DespawnCo()
        {
            // waits for the defined time.
            yield return new WaitForSeconds(despawnTime);

            // removes the object based on the user choice.
            switch (choices)
            {
                case DespawnerChoices.Disable:
                    gameObject.SetActive(false);
                    break;
                case DespawnerChoices.Destroy:
                    Destroy(gameObject);
                    break;
                default:
                    break;
            }
        }
    }
}