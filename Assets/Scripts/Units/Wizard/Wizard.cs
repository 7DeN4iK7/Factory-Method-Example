using UnityEngine;

namespace Units.Wizard
{
    public class Wizard : Unit
    {
        private float _spellCooldown;
        
        public void Init(UnitInfo unitInfo, float spellCooldown)
        {
            base.Init(unitInfo);
            _spellCooldown = spellCooldown;
        }

        public override void Attack()
        {
            Debug.Log($"[Wizard]: Im casting spell, now im on cooldown of {_spellCooldown} seconds");
        }
    }
}