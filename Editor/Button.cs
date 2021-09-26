using System;
using UnityEngine;

namespace JTools.Editor
{
    /// <summary>
    /// Contains some handy static method for adding buttons to custom editors.
    /// </summary>
    public static class Button
    {
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
            var _default = GUI.backgroundColor;
            GUI.backgroundColor = Colours.Green;
            if (GUILayout.Button(label, options))
                callback();
            GUI.backgroundColor = _default;
        }
        

        /// <summary>
        /// Shows a yellow button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void YellowButton(string label, Action callback, params GUILayoutOption[] options)
        {
            var _default = GUI.backgroundColor;
            GUI.backgroundColor = Colours.Yellow;
            if (GUILayout.Button(label, options))
                callback();
            GUI.backgroundColor = _default;
        }
        

        /// <summary>
        /// Shows a red button.
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void RedButton(string label, Action callback, params GUILayoutOption[] options)
        {
            var _default = GUI.backgroundColor;
            GUI.backgroundColor = Colours.Red;
            if (GUILayout.Button(label, options))
                callback();
            GUI.backgroundColor = _default;
        }


        /// <summary>
        /// Creates a button with the background colour to set the value entered...
        /// </summary>
        /// <param name="label">String | Label for the button.</param>
        /// <param name="color">The colour to set to</param>
        /// <param name="callback">Action | The actions to perform on button press.</param>
        /// <param name="options">GUILayoutOption[] | Layout options.</param>
        public static void ColourButton(string label, Color color, Action callback, params GUILayoutOption[] options)
        {
            var _default = GUI.backgroundColor;
            GUI.backgroundColor = color;
            if (GUILayout.Button(label, options))
                callback();
            GUI.backgroundColor = _default;
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
