using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace JTools.Editor
{
    public static class JEditorToolbox
    {
        public static Color32 grnCol = new Color32(72, 222, 55, 255);
        public static Color32 ylwCol = new Color32(245, 234, 56, 255);
        public static Color32 redCol = new Color32(255, 150, 157, 255);


        public static void Horizontal(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal();
            blockElements();
            EditorGUILayout.EndHorizontal();
        }
        
        public static void HorizontalBoxed(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal("box");
            blockElements();
            EditorGUILayout.EndHorizontal();
        }
        
        
        public static void HorizontalCentered(Action blockElements)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            blockElements();
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }
        
        
        public static void Vertical(Action blockElements)
        {
            EditorGUILayout.BeginVertical();
            blockElements();
            EditorGUILayout.EndVertical();
        }
        
        
        public static void VerticalBoxed(Action blockElements)
        {
            EditorGUILayout.BeginVertical("Box");
            blockElements();
            EditorGUILayout.EndVertical();
        }
        
        
        public static void VerticalCentered(Action blockElements)
        {
            EditorGUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            blockElements();
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndVertical();
        }


        public static void Label(string labelString, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(labelString, options);
        }
        
        
        public static void CompactLabel(string labelString)
        {
            labelString += " ";
            EditorGUILayout.LabelField(labelString, GUILayout.Width(TextWidth(labelString)));
        }

        public static void BoldCompactLabel(string labelString)
        {
            labelString += "    ";
            EditorGUILayout.LabelField(labelString, EditorStyles.boldLabel, GUILayout.Width(TextWidth(labelString)));
        }


        public static void Space(float space = 5f)
        {
            EditorGUILayout.Space(space);
        }


        public static bool Button(string label, params GUILayoutOption[] options)
        {
            return GUILayout.Button(label, options);
        }

        public static void GreenButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = grnCol;
            if (GUILayout.Button(label, options))
                callback();

            DefaultBackgroundColor();
        }


        public static void YellowButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = ylwCol;
            if (GUILayout.Button(label, options))
                callback();

            DefaultBackgroundColor();
        }


        public static void RedButton(string label, Action callback, params GUILayoutOption[] options)
        {
            GUI.backgroundColor = redCol;
            if (GUILayout.Button(label, options))
                callback();

            DefaultBackgroundColor();
        }


        public static bool CompactButton(string label, params GUILayoutOption[] options)
        {
            label += " ";
            return GUILayout.Button(label, GUILayout.Width(TextWidth(label)));
        }


        public static void EmptyButton(params GUILayoutOption[] options)
        {
            if (GUILayout.Button("", options))
            { }
        }


        public static void DefaultColor()
        {
            GUI.color = Color.white;
        }
        
        public static void DefaultBackgroundColor()
        {
            GUI.backgroundColor = Color.white;
        }


        public static float TextWidth(string text)
        {
            return GUI.skin.label.CalcSize(new GUIContent(text)).x;
        }


        public static void DeselectRegion(Action callback)
        {
            var deselectWindow = new Rect(0, 0, Screen.width, Screen.height);

            callback();

            if (GUI.Button(deselectWindow, "", GUIStyle.none))
            {
                GUI.FocusControl(null);
            }
        }


        public static int Toolbar(int value, string[] labels)
        {
            return GUILayout.Toolbar(value, labels);
        }
    }
}
