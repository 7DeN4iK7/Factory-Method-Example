using Units;
using UnityEngine;

namespace FactoryMethod
{
    public abstract class UnitFactory
    {
        protected UnitInfo _unitInfo;
        public UnitFactory(UnitInfo unitInfo)
        {
            _unitInfo = unitInfo;
        }

        public abstract Unit CreateUnit(Vector2 worldPosition);
    }
}
