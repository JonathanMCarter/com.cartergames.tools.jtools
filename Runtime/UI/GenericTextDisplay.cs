using TMPro;
using UnityEngine;

namespace JTools.UI
{
    public class GenericTextDisplay : MonoBehaviour
    {
        protected TMP_Text display;
        
        /// <summary>
        /// Gets the text element used in this script...
        /// </summary>
        public TMP_Text GetText => display;
        
        
        protected virtual void Awake()
        {
            display = GetComponentInChildren<TMP_Text>(true);
        }
        

        /// <summary>
        /// Updates the display on call...
        /// </summary>
        /// <param name="value">The value to update to</param>
        protected virtual void UpdateDisplay(string value)
        {
            display.text = value;
        }
    }
}