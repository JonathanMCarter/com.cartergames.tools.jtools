using UnityEngine;
using UnityEngine.UI;

namespace JTools
{
    public class ProgressBar : MonoBehaviour
    {
        private Image fill;
        private float cachedMaxAmount;
        
        
        private void Awake()
        {
            fill = GetComponentInChildren<Image>();
            fill.fillAmount = 0;
        }

        
        /// <summary>
        /// Sets up the progress bar for use...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        /// <param name="maxAmount">The max amount the bar can be filled to</param>
        public void SetupBar(float amount, float maxAmount)
        {
            if (!cachedMaxAmount.Equals(maxAmount))
                cachedMaxAmount = maxAmount;
            
            fill.fillAmount = amount / maxAmount;
        }
        
        
        /// <summary>
        /// Sets the fill of the bar to the entered value...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        public void SetFill(float amount)
        {
            fill.fillAmount = amount / cachedMaxAmount;
        }
        
        
        /// <summary>
        /// Sets the fill of the bar to the entered value...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        /// <param name="maxAmount">The max amount the bar can be filled to</param>
        public void SetFill(float amount, float maxAmount)
        {
            if (!cachedMaxAmount.Equals(maxAmount))
                cachedMaxAmount = maxAmount;
            
            fill.fillAmount = amount / maxAmount;
        }
    }
}