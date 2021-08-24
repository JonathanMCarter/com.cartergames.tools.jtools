using System;
using UnityEngine;
using UnityEditor;

namespace JTools.Editor
{
    /// <summary>
    /// Contains some handy static method for adding buttons to custom editors.
    /// </summary>
    public static class Button
    {
        /// <summary>
        /// The Green colour used in the button.
        /// </summary>
        private static Color32 grnCol = new Color32(72, 222, 55, 255);
        
        
        /// <summary>
        /// The Yellow colour used in the button.
        /// </summary>
        private static Color32 ylwCol = new Color32(245, 234, 56, 255);
        
        
        /// <summary>
        /// The Red colour used in the button.
        /// </summary>
        private static Color32 redCol = new Color32(255, 150, 157, 255);
        
        
        
        /// <summary>
        /// Shows a normal button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        /// <returns>Bool</returns>
        public static bool PlainButton(string label, params GUILayoutOption[] options)
        {
            return GUILayout.Button(label, options);
        }


        /// <summary>
        /// Shows a green button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void GreenButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = grnCol;
            if (GUILayout.Button(label, options))
                callback();
        }
        

        /// <summary>
        /// Shows a yellow button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void YellowButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = ylwCol;
            if (GUILayout.Button(label, options))
                callback();
        }
        

        /// <summary>
        /// Shows a red button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void RedButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = redCol;
            if (GUILayout.Button(label, options))
                callback();
        }
        
        
        /// <summary>
        /// Shows a compact button where the label controls the size of the button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <returns>Bool</returns>
        public static bool CompactButton(string label)
        {
            label += " ";
            return GUILayout.Button(label, GUILayout.Width(Label.TextWidth(label)));
        }
        
        
        /// <summary>
        /// Shows an empty button.
        /// </summary>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void EmptyButton(params GUILayoutOption[] options)
        {
            if (GUILayout.Button("", options))
            { }
        }
    }
}
