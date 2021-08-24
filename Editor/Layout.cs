using System;
using UnityEngine;
using UnityEditor;

namespace JTools.Editor
{
    /// <summary>
    /// Holds some static methods to help with EditorGUILayout setup in custom editors.
    /// </summary>
    public static class Layout
    {
        /// <summary>
        /// Make a EditorGUILayout.BeginHorizontal.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void Horizontal(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal();
            blockElements();
            EditorGUILayout.EndHorizontal();
        }
        
        
        /// <summary>
        /// Make a EditorGUILayout.BeginHorizontal...with a Box GUIStyle.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void HorizontalBoxed(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal("box");
            blockElements();
            EditorGUILayout.EndHorizontal();
        }
        

        /// <summary>
        /// Make a EditorGUILayout.BeginHorizontal...with content that is centered.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void HorizontalCentered(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            blockElements();
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }
        
        
        /// <summary>
        /// Make a EditorGUILayout.BeginVertical.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void Vertical(Action blockElements)
        {
            EditorGUILayout.BeginVertical();
            blockElements();
            EditorGUILayout.EndVertical();
        }
        
        
        /// <summary>
        /// Make a EditorGUILayout.BeginVertical...with a Box GUIStyle.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void VerticalBoxed(Action blockElements)
        {
            EditorGUILayout.BeginVertical("Box");
            blockElements();
            EditorGUILayout.EndVertical();
        }
        
        
        /// <summary>
        /// Make a EditorGUILayout.BeginVertical...with content that is centered.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void VerticalCentered(Action blockElements)
        {
            EditorGUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            blockElements();
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndVertical();
        }


        /// <summary>
        /// Makes a GUILayout.Toolbar...
        /// </summary>
        /// <param name="pos">The position variable to edit and update with the active tab int.</param>
        /// <param name="labels">The labels for the tabs.</param>
        /// <param name="options">any special params you wish to pass in.</param>
        /// <returns>Int</returns>
        public static int Tabs(int pos, string[] labels, params GUILayoutOption[] options)
        {
            return GUILayout.Toolbar(pos, labels, options);
        }
        
        
        /// <summary>
        /// Adds some space based on the value entered.
        /// </summary>
        /// <param name="space">The amount of space to give.</param>
        /// <remarks>Default is 5f</remarks>
        public static void Space(float space = 5f)
        {
            EditorGUILayout.Space(space);
        }
        
        
        /// <summary>
        /// Creates a deselect region which allows the user to click anywhere on the custom editor to deselect fields.
        /// </summary>
        /// <param name="blockElements">Action | Stuff to display</param>
        /// <remarks>Actions can be () => {} or a method.</remarks>
        public static void DeselectRegion(Action blockElements)
        {
            var deselectWindow = new Rect(0, 0, Screen.width, Screen.height);

            blockElements();

            if (GUI.Button(deselectWindow, "", GUIStyle.none))
                GUI.FocusControl(null);
        }
    }
}