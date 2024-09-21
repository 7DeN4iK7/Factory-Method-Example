using System;
using Units;
using Units.Warrior;
using UnityEngine;

namespace FactoryMethod.WarriorFactory
{
    public class WarriorFactory : UnitFactory
    {
        private string _swordName;
        public WarriorFactory(UnitInfo unitInfo, string swordName) : base(unitInfo)
        {
            _swordName = swordName;
        }

        public override Unit CreateUnit(Vector2 worldPosition)
        {
            Warrior wizard = new GameObject().AddComponent<Warrior>();
            wizard.Init(_unitInfo, _swordName);
            wizard.gameObject.AddComponent<SpriteRenderer>().sprite = _unitInfo.sprite;
            wizard.transform.position = worldPosition;
            return wizard;
        }
    }
}