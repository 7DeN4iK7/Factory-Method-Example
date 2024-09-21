using Units;
using Units.Warrior;
using Units.Wizard;
using UnityEngine;

namespace FactoryMethod.WizardFactory
{
    public class WizardFactory : UnitFactory
    {
        private float _spellCooldown;
        
        public WizardFactory(UnitInfo unitInfo, float spellCooldown) : base(unitInfo)
        {
            _spellCooldown = spellCooldown;
        }

        public override Unit CreateUnit(Vector2 worldPosition)
        {
            Wizard wizard = new GameObject().AddComponent<Wizard>();
            wizard.Init(_unitInfo, _spellCooldown);
            wizard.gameObject.AddComponent<SpriteRenderer>().sprite = _unitInfo.sprite;
            wizard.transform.position = worldPosition;
            return wizard;
        }
    }
}