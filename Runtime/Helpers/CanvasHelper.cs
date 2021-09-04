using UnityEngine;

namespace JTools
{
    /// <summary>
    /// Helper methods for Canvas/Canvas Groups...
    /// </summary>
    public static class CanvasHelper
    {
        /// <summary>
        /// Disables the canvas group entered.
        /// </summary>
        /// <param name="group">The group to edit.</param>
        /// <param name="changeAlpha">Should the alpha value be changed? Default = true.</param>
        public static void DisableCanvasGroup(CanvasGroup group, bool changeAlpha = true)
        {
            if (changeAlpha)
                group.alpha = 0;
            
            group.interactable = false;
            group.blocksRaycasts = false;
            group.ignoreParentGroups = false;
        }
        
        
        /// <summary>
        /// Enables the canvas group entered.
        /// </summary>
        /// <param name="group">The group to edit.</param>
        /// <param name="changeAlpha">Should the alpha value be changed? Default = true.</param>
        /// <param name="ignoreParentGroups">Should ignore parent groupings? Default = false.</param>
        public static void EnableCanvasGroup(CanvasGroup group, bool changeAlpha = true, bool ignoreParentGroups = false)
        {
            if (changeAlpha)
                group.alpha = 1;
            
            group.interactable = true;
            group.blocksRaycasts = true;
            group.ignoreParentGroups = ignoreParentGroups;
        }
    }
}