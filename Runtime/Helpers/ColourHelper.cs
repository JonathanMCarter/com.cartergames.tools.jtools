using UnityEngine;

namespace JTools
{
    /// <summary>
    /// Some handy methods for dealing with colours...
    /// </summary>
    public static class ColourHelper
    {
        /// <summary>
        /// Changes the colour without affecting the alpha value of the colour it is replacing...
        /// </summary>
        /// <param name="toEdit">The colour to edit...</param>
        /// <param name="toChangeTo">The colour to change to...</param>
        /// <returns>Color</returns>
        public static Color ColorNoAlphaEdit(Color toEdit, Color toChangeTo)
            => new Color(toChangeTo.r, toChangeTo.g, toChangeTo.b, toEdit.a);
        


        /// <summary>
        /// Changes the colour's with a change to the alpha value as well...
        /// </summary>
        /// <param name="toChangeTo">The colour to edit...</param>
        /// <param name="alphaValue">The alpha value to set to...</param>
        /// <returns>Color</returns>
        public static Color ColorDifferentAlpha(Color toChangeTo, float alphaValue)
            => new Color(toChangeTo.r, toChangeTo.g, toChangeTo.b, alphaValue / 255f);
        


        /// <summary>
        /// Changes the alpha of the colour without affecting the colour itself...
        /// </summary>
        /// <param name="col">The colour to edit...</param>
        /// <param name="alpha">The alpha to set...</param>
        /// <returns>Color</returns>
        public static Color ChangeAlpha(Color col, float alpha)
        {
            col.a = alpha;
            return col;
        }
        

        /// <summary>
        /// Checks to see if the colours match....
        /// </summary>
        /// <param name="x">The first colour to check...</param>
        /// <param name="y">The second colour to check...</param>
        /// <returns>Bool</returns>
        /// <remarks>This method doesn't compare the alpha...</remarks>
        public static bool ColorsMatch(Color x, Color y)
            => Mathf.Approximately(x.r, y.r) && Mathf.Approximately(x.g, y.g) && Mathf.Approximately(x.b, y.b);
        
        
        
        /// <summary>
        /// Checks to see if the colours match....
        /// </summary>
        /// <param name="x">The first colour to check...</param>
        /// <param name="y">The second colour to check...</param>
        /// <returns>Bool</returns>
        /// <remarks>This method does compare the alpha...</remarks>
        public static bool ColorsMatchIncAlpha(Color x, Color y)
            => Mathf.Approximately(x.r, y.r) && Mathf.Approximately(x.g, y.g) && Mathf.Approximately(x.b, y.b) && Mathf.Approximately(x.a, y.a);
        
    }
}
