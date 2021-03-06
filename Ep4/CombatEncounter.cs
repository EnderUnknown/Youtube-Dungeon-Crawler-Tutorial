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
            foreach (EncounterAction action in player.GetCombatActions())
                actions.Add(new ActionButton(action.item.name, (Encounter encounter) => {
                    CombatEncounter e = (CombatEncounter)encounter;
                    GameEngine.game.WriteText("");
                    action.action(e, e.player, e.enemy);
                    e.enemy.FightBack(e, e.player);
                    WriteHealth(e);
                    GameEngine.game.UpdatePlayerStats();
                    if (e.enemy.isDead)
                    {
                        e.player.inventory.AddRange(e.enemy.inventory);
                        encounter.actions.Clear();
                        encounter.actions.Add(new ActionButton("Continue", (Encounter en) => { GameEngine.instance.DoNextEncounter(); }));
                        encounter.RefreshActions();
                    }
                }));
        }

        private void WriteHealth(CombatEncounter c)
        {
            if (c.enemy.isDead) return;
            GameEngine.game.AppendText($"{c.enemy.name} : {c.enemy.currentHealth}");
        }

        //private void Strike(Encounter encounter)
        //{
        //    CombatEncounter e = (CombatEncounter)encounter;
        //    int amount = e.player.Attack(e.enemy);
        //    string text = DoEnemyTurn(e);
        //    GameEngine.game.WriteText($"You punch the {enemy.name} for {amount} kinetic damage. {text}.");
        //    GameEngine.game.UpdatePlayerStats();
        //}

        //private string DoEnemyTurn(CombatEncounter encounter)
        //{
        //    int amount = encounter.enemy.Attack(encounter.player);
        //    if (amount < 0) return "The elf has died.";
        //    return $"{enemy.name} attacks you back for {amount} kinetic damage. {enemy.name}: {enemy.currentHealth}";
        //}

        private static string[] prompts = new string[] {"You turn the corner and see","At the end of the hall, there is a","Looking into the room, you see a"};
        public static CombatEncounter GenerateEncounter()
        {
            Enemy enemy = Enemy.GenerateEnemy();
            string prompt = $"{prompts[RandomHelper.rand.Next(prompts.Length)]} {enemy.name}. {enemy.name}: {enemy.currentHealth}";
            CombatEncounter encounter = new CombatEncounter("Fight!", prompt, new List<ActionButton>(), enemy);
            return encounter;
        }
    }
}
