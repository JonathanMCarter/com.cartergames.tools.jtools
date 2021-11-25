using UnityEngine;
using UnityEngine.UI;

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
        
        
        /// <summary>
        /// Enables the canvas and raycaster if attached...
        /// </summary>
        /// <param name="canvas">The canvas to edit</param>
        public static void EnableCanvas(Canvas canvas)
        {
            canvas.enabled = true;
            if (!TryGet.ComponentInChildren(canvas.gameObject, out GraphicRaycaster _raycaster)) return;
            _raycaster.enabled = true;
        }
        

        /// <summary>
        /// Enables the canvas and raycaster...
        /// </summary>
        /// <param name="canvas">The canvas to edit</param>
        /// <param name="raycaster">The raycaster to toggle</param>
        public static void EnableCanvas(Canvas canvas, GraphicRaycaster raycaster)
        {
            canvas.enabled = true;
            raycaster.enabled = true;
        }

        
        /// <summary>
        /// Disabled the canvas and raycaster if attached...
        /// </summary>
        /// <param name="canvas">The canvas to edit</param>
        public static void DisableCanvas(Canvas canvas)
        {
            canvas.enabled = false;
            if (!TryGet.ComponentInChildren(canvas.gameObject, out GraphicRaycaster _raycaster)) return;
            _raycaster.enabled = false;
        }
        

        /// <summary>
        /// Disabled the canvas and raycaster...
        /// </summary>
        /// <param name="canvas">The canvas to edit</param>
        /// <param name="raycaster">The raycaster to toggle</param>
        public static void DisableCanvas(Canvas canvas, GraphicRaycaster raycaster)
        {
            canvas.enabled = false;
            raycaster.enabled = false;
        }
    }
}