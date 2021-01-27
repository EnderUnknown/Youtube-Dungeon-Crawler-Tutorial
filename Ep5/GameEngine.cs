using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class GameEngine
    {
        public static GameEngine instance;
        public static Game game;
        public static Player currentPlayer;

        public GameEngine(Game instance)
        {
            currentPlayer = new Player();
            game = instance;

            currentPlayer.InvAdd(Items.Items.sword);
            currentPlayer.InvAdd(Items.Items.knife);

            DoNextEncounter();
            //game.SetEncounter(CombatEncounter.combatOne);
        }

        public void DoNextEncounter()
        {
            game.SetEncounter(CombatEncounter.GenerateEncounter());
        }

        
    }
}
