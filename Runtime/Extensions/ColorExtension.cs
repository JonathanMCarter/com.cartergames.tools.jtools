// ----------------------------------------------------------------------------
// ColorExtensions.cs
// 
// Author: Jonathan Carter (A.K.A. J)
// Date: 22/12/2021
// ----------------------------------------------------------------------------

using UnityEngine;

namespace JTools
{
    public static class ColorExtension
    {
        public static bool Match(this Color color, Color b, bool compareAlpha = false)
        {
            return compareAlpha 
                ? Mathf.Approximately(color.r, b.r) && Mathf.Approximately(color.g, b.g) && Mathf.Approximately(color.b, b.b) && Mathf.Approximately(color.a, b.a)
                : Mathf.Approximately(color.r, b.r) && Mathf.Approximately(color.g, b.g) && Mathf.Approximately(color.b, b.b);
        }
        
        public static Color ChangeAlpha(this Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

        public static Color ChangeColor(this Color color, Color b)
        {
            return new Color(b.r, b.g, b.b, color.a);
        }
    }
}