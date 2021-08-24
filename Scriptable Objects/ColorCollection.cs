using System;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Color Collection", menuName = "JTools/Collections/Color Collection", order = 1)]
    [Serializable]
    public class ColorCollection : ScriptableObject
    {
        public Color[] collection;
        public string colourBlindnessShortString;
        public short colorBlindnessIcon;
    }
}