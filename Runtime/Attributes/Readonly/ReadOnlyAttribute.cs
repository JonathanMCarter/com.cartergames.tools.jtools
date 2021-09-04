using UnityEngine;

namespace JTools
{
    /// <summary>
    /// The attribute [ReadOnly]. for making exposed elements in the inspector be read-only (disables the GUI).
    /// </summary>
    public class ReadOnlyAttribute : PropertyAttribute
    {
        /// <summary>
        /// Blank Constructor...
        /// </summary>
        public ReadOnlyAttribute() { }
    }
}