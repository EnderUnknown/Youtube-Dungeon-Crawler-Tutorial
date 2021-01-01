using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public class WeaponBase : ItemBase
    {
        public static WeaponBase theWeapon = new WeaponBase("The Weapon Called Hello World");
        public static WeaponBase sword = new WeaponBase("Sword", () => { return RandomHelper.DoRoll(6, 2); });

        public Damage.GetDamage damageCalc = ()=> { return RandomHelper.DoRoll(4) + 1; };
        public string damageType = "kinetic";

        public WeaponBase(string name) : base(name)
        {

        }
        public WeaponBase(string name, Damage.GetDamage calc, string damageType = "kinetic") : base(name)
        {
            damageCalc = calc;
            this.damageType = damageType;
        }

        private Damage GetDamage()
        {
            return new Damage(damageCalc(), damageType);
        }

        public override List<EncounterAction> GetCombatActions()
        {
            return new List<EncounterAction>() {new EncounterAction(this, DoCombat)};
        }

        public virtual void DoCombat(Encounter encounter, LivingBase user, LivingBase target)
        {
            //Combat Code
            Damage amount = user.Attack(target, GetDamage());
            GameEngine.game.AppendText($"{user.name} attacks {target.name} for {amount.amount} {amount.type} damage.\n");
        }
    }
}
