using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Enemy : LivingBase
    {
        public Enemy(string name, int maxHealth, int power)
        {
            this.name = name;
            this.power = power;

            genericMaxHealth = maxHealth;
            currentHealth = GetMaxHealth();
        }
    }
}
