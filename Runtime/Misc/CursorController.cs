using System;
using UnityEngine;

namespace JTools
{
    public class CursorController : MonoBehaviour
    {
        [SerializeField] private CursorOptions options;
        [SerializeField] private Texture2D cursorTexture;

        private void Update()
        {
            switch (options)
            {
                case CursorOptions.Unassigned:
                    break;
                case CursorOptions.Disabled:

                    if (Cursor.visible)
                        Cursor.visible = false;
                    
                    break;
                case CursorOptions.Texture:
                    
                    Cursor.SetCursor(cursorTexture, Vector2.one, CursorMode.Auto);
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}