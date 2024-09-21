using UnityEngine;

namespace Units
{
    public abstract class Unit : MonoBehaviour
    {
        private UnitInfo _unitInfo;

        protected void Init(UnitInfo unitInfo)
        {
            _unitInfo = unitInfo;
        }

        public abstract void Attack();
    }
}