using UnityEngine;

namespace JTools.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New String Collection", menuName = "JTools/Collections/String Collection", order = 0)]
    public class StringCollection : ScriptableObject
    {
        public string[] collection;
    }
}