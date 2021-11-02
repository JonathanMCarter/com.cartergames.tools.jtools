using UnityEditor;
using UnityEngine;

namespace JTools
{
    [CustomPropertyDrawer(typeof(MinMax))]
    public class MinMaxPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);
            
            var _min = property.FindPropertyRelative("min");
            var _max = property.FindPropertyRelative("max");
            
            EditorGUI.BeginChangeCheck();

            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var _left = new Rect(position.x, position.y, (position.width / 2) - 1.5f, EditorGUIUtility.singleLineHeight);
            var _right = new Rect(position.x + position.width / 2 + 1.5f, position.y, (position.width / 2) - 1.5f, EditorGUIUtility.singleLineHeight);

            EditorGUI.PropertyField(_left, _min, GUIContent.none);
            EditorGUI.PropertyField(_right, _max, GUIContent.none);

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();            
            
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}