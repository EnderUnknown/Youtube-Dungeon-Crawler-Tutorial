﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class CombatEncounter : Encounter
    {
        public static CombatEncounter combatOne = new CombatEncounter("Fight!", "You see an enemy. Elf: 5", new List<ActionButton>(), new Enemy("Elf", 5, 1));
        Enemy enemy;
        public CombatEncounter(string title, string prompt, List<ActionButton> actions, Enemy enemy) : base(title, prompt, actions)
        {
            this.enemy = enemy;
        }

        public override void StartEncounter(Player player)
        {
            base.StartEncounter(player);
            actions.Add(new ActionButton("Strike", Strike));
        }

        private void Strike(Encounter encounter)
        {
            CombatEncounter e = (CombatEncounter)encounter;
            int amount = e.player.Attack(e.enemy);
            string text = DoEnemyTurn(e);
            GameEngine.game.WriteText($"You punch the {enemy.name} for {amount} kinetic damage. {text}.");
            GameEngine.game.UpdatePlayerStats();
        }

        private string DoEnemyTurn(CombatEncounter encounter)
        {
            int amount = encounter.enemy.Attack(encounter.player);
            if (amount < 0) return "The elf has died.";
            return $"{enemy.name} attacks you back for {amount} kinetic damage. {enemy.name}: {enemy.currentHealth}";
        }
    }
}
