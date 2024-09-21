using UnityEngine;

namespace Units
{
    [CreateAssetMenu]
    public class UnitInfo : ScriptableObject
    {
        public int damage;
        public float moveSpeed;
        public Sprite sprite;
    }
}
