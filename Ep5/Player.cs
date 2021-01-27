using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler.Items;

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

            //inventory.Add(Items.WeaponBase.knife);
            //inventory.Add(Items.WeaponBase.sword);
        }

        public void InvAdd(ItemBase item)
        {
            AddItem(item);
            GameEngine.game.UpdateInventory();
        }
        public void InvRemove(ItemBase item, int quantity)
        {
            RemoveItem(item, quantity);
            GameEngine.game.UpdateInventory();
        }

        public void InvAdd(ItemBase[] items)
        {
            foreach (ItemBase i in items)
                AddItem(i);

            GameEngine.game.UpdateInventory();
        }
    }
}
