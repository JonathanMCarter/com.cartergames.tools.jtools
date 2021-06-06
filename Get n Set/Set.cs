using UnityEngine;

namespace JTools.GetSet
{
    public static class Set
    {
        public static Color ColorNoAlphaEdit(Color toEdit, Color toChangeTo)
        {
            return new Color(toChangeTo.r, toChangeTo.g, toChangeTo.b, toEdit.a);
        }


        public static Color ColorDifferentAlpha(Color toChangeTo, float alphaValue)
        {
            return new Color(toChangeTo.r, toChangeTo.g, toChangeTo.b, alphaValue / 255f);
        }
    }
}