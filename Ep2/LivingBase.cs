using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Attack(LivingBase target)
        {
            if (isDead) return -1;
            return target.DoDamage(new Damage(power));
        }

        public int DoDamage(Damage damage)
        {
            if (IsIm(damage.type)) return 0;
            float resMod = (IsRes(damage.type)) ? 0.5f : 1;
            int vulMod = (IsVul(damage.type)) ? 2 : 1;

            int amount = (int)Math.Ceiling((decimal)(damage.amount * resMod * vulMod));

            currentHealth -= amount;
            if (ShouldDie())
                Death();
            return amount;
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
