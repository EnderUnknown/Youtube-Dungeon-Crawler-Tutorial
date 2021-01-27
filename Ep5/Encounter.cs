using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Encounter
    {
        public string title;
        public string prompt;
        public List<ActionButton> actions;
        public Player player;

        public Encounter(string title, string prompt,List<ActionButton> actions)
        {
            this.title = title;
            this.prompt = prompt;
            this.actions = actions;
        }

        public virtual void StartEncounter(Player player)
        {
            this.player = player;
        }

        public virtual void OnFinish()
        {
            GameEngine.instance.DoNextEncounter();
        }

        public void RefreshActions()
        {
            GameEngine.game.RefreshActions(this);
        }
    }
}
