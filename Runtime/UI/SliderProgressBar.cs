using UnityEngine;
using UnityEngine.UI;

namespace JTools
{
    public class SliderProgressBar : MonoBehaviour
    {
        private Slider slider;
        private float cachedMaxAmount;
        
        
        private void Awake()
        {
            slider = GetComponentInChildren<Slider>();
            slider.value = 0;
        }

        
        /// <summary>
        /// Sets up the progress bar for use...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        /// <param name="maxAmount">The max amount the bar can be filled to</param>
        /// <param name="invert">Should the result be inverted?</param>
        public void SetupBar(float amount, float maxAmount, bool invert = false)
        {
            if (!cachedMaxAmount.Equals(maxAmount))
                cachedMaxAmount = maxAmount;

            var _value = amount / maxAmount;

            if (invert)
            {
                slider.value = GetGeneral.Invert01(_value);
                return;
            }

            slider.value = _value;
        }
        
        
        /// <summary>
        /// Sets the fill of the bar to the entered value...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        /// <param name="invert">Should the result be inverted?</param>
        public void SetFill(float amount, bool invert = false)
        {
            var _value = amount / cachedMaxAmount;

            if (invert)
            {
                slider.value = GetGeneral.Invert01(_value);
                return;
            }

            slider.value = _value;
        }
        
        
        /// <summary>
        /// Sets the fill of the bar to the entered value...
        /// </summary>
        /// <param name="amount">The amount to fill by</param>
        /// <param name="maxAmount">The max amount the bar can be filled to</param>
        /// <param name="invert">Should the result be inverted?</param>
        public void SetFill(float amount, float maxAmount, bool invert = false)
        {
            if (!cachedMaxAmount.Equals(maxAmount))
                cachedMaxAmount = maxAmount;
            
            var _value = amount / cachedMaxAmount;

            if (invert)
            {
                slider.value = GetGeneral.Invert01(_value);
                return;
            }

            slider.value = _value;
        }
    }
}