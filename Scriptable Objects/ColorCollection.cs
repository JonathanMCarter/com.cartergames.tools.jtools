using UnityEngine;

namespace JTools.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Color Collection", menuName = "JTools/Collections/Color Collection", order = 1)]
    public class ColorCollection : ScriptableObject
    {
        public Color[] collection;
    }
}