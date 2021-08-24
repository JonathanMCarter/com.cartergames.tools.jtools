using UnityEngine;

namespace JTools.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Sprite Collection", menuName = "JTools/Collections/Sprite Collection", order = 10)]
    public class SpriteCollection : ScriptableObject
    {
        public Sprite[] collection;
    }
}