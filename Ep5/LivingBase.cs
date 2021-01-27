using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public abstract class LivingBase
    {
        public string name;
        public int genericMaxHealth;
        public int currentHealth;

        public int power;
        public bool isDead;

        public List<string> damageRes = new List<string>();
        public List<string> damageVul = new List<string>();
        public List<string> damageIm = new List<string>();

        public List<ItemBase> inventory = new List<ItemBase>();

        public void AddItem(ItemBase item)
        {
            ItemBase target = inventory.Find(x => x.name == item.name);
            if (target == null)
                inventory.Add(item);
            else
                target.AddQuantity(item.quantity);
        }

        public bool CanRemoveItem(ItemBase item, int quantity)
        {
            ItemBase target = inventory.Find(x => x.name == item.name);
            if (target == null) return false;

            int remainder = target.quantity - quantity;
            return remainder >= 0;
        }

        public void RemoveItem(ItemBase item, int quantity)
        {
            ItemBase target = inventory.Find(x => x.name == item.name);
            if (target == null) return;

            target.AddQuantity(-quantity);
            if (target.quantity <= 0)
                inventory.Remove(target);
        }

        public List<EncounterAction> GetCombatActions()
        {
            List<EncounterAction> actions = new List<EncounterAction>();
            foreach (ItemBase item in inventory)
                actions.AddRange(item.GetCombatActions());
            return actions;
        }

        public int GetMaxHealth()
        {
            return genericMaxHealth;
        }

        public bool IsRes(string type)
        {
            return damageRes.Contains(type);
        }
        public bool IsIm(string type)
        {
            return damageIm.Contains(type);
        }
        public bool IsVul(string type)
        {
            return damageVul.Contains(type);
        }

        public Damage Attack(LivingBase target)
        {
            if (isDead) return Damage.NONE;
            return target.DoDamage(new Damage(power));
        }

        public Damage Attack(LivingBase target, Damage damage)
        {
            if (isDead) return Damage.NONE;
            return target.DoDamage(damage);
        }

        public Damage DoDamage(Damage damage)
        {
            if (IsIm(damage.type)) return new Damage(0,damage.type);
            float resMod = (IsRes(damage.type)) ? 0.5f : 1;
            int vulMod = (IsVul(damage.type)) ? 2 : 1;

            int amount = (int)Math.Ceiling((decimal)(damage.amount * resMod * vulMod));

            currentHealth -= amount;
            if (ShouldDie())
                Death();
            return new Damage(amount,damage.type);
        }

        public bool ShouldDie()
        {
            return currentHealth <= 0;
        }

        public void Death()
        {
            isDead = true;
        }
    }
}
