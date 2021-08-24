using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Int Collection", menuName = "JTools/Collections/Int Collection", order = 10)]
    public class IntCollection : ScriptableObject
    {
        public int[] collection;
    }
}