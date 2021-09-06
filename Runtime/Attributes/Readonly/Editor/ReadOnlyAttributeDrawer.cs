using UnityEditor;
using UnityEngine;

namespace JTools.Editor
{
#if UNITY_EDITOR
    /// <summary>
    /// The Property Drawer for the [ReadOnly] attribute...
    /// </summary>
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyAttributeDrawer : PropertyDrawer
    {
        /// <summary>
        /// Overrides the OnGUI method with what is entered below...
        /// </summary>
        /// <param name="position">The position to use</param>
        /// <param name="property">The property to use</param>
        /// <param name="label">The label to use</param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Disabled the GUI...
            GUI.enabled = false;
            
            // Draws the property as normal...
            EditorGUI.PropertyField(position, property, label);
            
            // Enabled the GUI again after this element...
            GUI.enabled = true;
        }
    }
    #endif
}
