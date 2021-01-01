using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Player : LivingBase
    {
        public Player()
        {
            name = "Player One";
            genericMaxHealth = 10;
            currentHealth = GetMaxHealth();
            power = 2;

            inventory.Add(Items.WeaponBase.theWeapon);
            inventory.Add(Items.WeaponBase.sword);
        }
    }
}
