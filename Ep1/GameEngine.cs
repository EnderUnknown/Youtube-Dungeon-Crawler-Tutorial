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

        public GameEngine(Game instance)
        {
            game = instance;
            game.SetEncounter(Encounter.firstEncounter);
        }

        
    }
}
