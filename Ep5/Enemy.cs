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


        public void FightBack(CombatEncounter encounter, Player player)
        {
            if (isDead) {
                GameEngine.game.AppendText($"{name} has died.");
                return;
            }
            EncounterAction[] actions = GetCombatActions().ToArray();
            EncounterAction.EncounterActionDelegate action;
            if (actions == null || actions.Length<1)
            {
                action = Strike;
            }
            else
            {
                action = actions[RandomHelper.rand.Next(0, actions.Length)].action;
            }

            action(encounter, this, player);
        }

        private void Strike(Encounter encounter, LivingBase user, LivingBase target)
        {
            Damage amount = user.Attack(target);
            GameEngine.game.AppendText($"{user.name} slashes {target.name} for {amount.amount} {amount.type} damage.\n");
        }

        private static string[] nameModOne = new string[] {"Hasty","Undead","Strong","Powerful"};
        private static string[] enemyTitles = new string[] {"Fire", "Ice", "Poison","Arch"};
        private static string[] enemyNames = new string[] { "Wizard", "Warrior", "Zombie", "Elf" };

        public static Enemy GenerateEnemy()
        {
            string name = $"{nameModOne[RandomHelper.rand.Next(nameModOne.Length)]} {enemyTitles[RandomHelper.rand.Next(enemyTitles.Length)]} {enemyNames[RandomHelper.rand.Next(enemyNames.Length)]}";

            Enemy enemy = new Enemy(name, RandomHelper.DoRoll(4,2)+2, RandomHelper.DoRoll(2));
            enemy.inventory.Add((RandomHelper.rand.Next(4)==0)?Items.Items.shortSword.Create():Items.Items.knife.Create());
            return enemy;
        }
    }
}
