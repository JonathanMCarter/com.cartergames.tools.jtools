using UnityEngine;
using UnityEditor;

namespace JTools.Editor
{
    /// <summary>
    /// Holds a collection of static methods to help with adding labels to custom editors.
    /// </summary>
    public static class Label
    {
        /// <summary>
        /// Adds a plain label with no special styling or effects.
        /// </summary>
        /// <param name="labelString">The text to display.</param>
        /// <param name="options">any special params you wish to pass in.</param>
        public static void Plain(string labelString, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(labelString, options);
        }
        
        
        /// <summary>
        /// Adds a bold label with no other special styling or effects.
        /// </summary>
        /// <param name="labelString">The text to display.</param>
        /// <param name="options">any special params you wish to pass in.</param>
        public static void Bold(string labelString, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(labelString, EditorStyles.boldLabel, options);
        }
        
        
        /// <summary>
        /// Adds a compact label with no other special styling or effects.
        /// </summary>
        /// <param name="labelString">The text to display.</param>
        public static void Compact(string labelString)
        {
            labelString += " ";
            EditorGUILayout.LabelField(labelString, GUILayout.Width(TextWidth(labelString)));
        }


        /// <summary>
        /// Adds a compact label with a bold style.
        /// </summary>
        /// <param name="labelString">The text to display.</param>
        public static void BoldCompact(string labelString)
        {
            labelString += "    ";
            EditorGUILayout.LabelField(labelString, EditorStyles.boldLabel, GUILayout.Width(TextWidth(labelString)));
        }
        

        /// <summary>
        /// Gets the text width of the text entered.
        /// </summary>
        /// <param name="text">The text to get the width of.</param>
        /// <returns>Float</returns>
        public static float TextWidth(string text)
        {
            return GUI.skin.label.CalcSize(new GUIContent(text)).x;
        }
    }
}