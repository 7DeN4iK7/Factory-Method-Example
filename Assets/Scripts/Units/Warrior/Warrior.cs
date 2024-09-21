using UnityEngine;

namespace Units.Warrior
{
    public class Warrior : Unit
    {
        private string _swordName;
        
        public void Init(UnitInfo unitInfo, string swordName)
        {
            base.Init(unitInfo);
            _swordName = swordName;
        }

        public override void Attack()
        {
            Debug.Log(string.IsNullOrWhiteSpace(_swordName)
                ? "[Warrior]: I DONT HAVE ANY WEAPON!"
                : $"[Warrior]: IM GONNA HIT YOU WITH MY GREATEST SWORD - {_swordName} ");
        }
    }
}