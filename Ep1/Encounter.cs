using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Encounter
    {
        public static Encounter firstEncounter = new Encounter("Awakening", "You awake in a cold room. What do you do?", new List<ActionButton>() {new ActionButton("Exit Game",new ActionButton.DoAction((Encounter encounter)=>
        {
            Environment.Exit(7);
        })),new ActionButton("Close Game",new ActionButton.DoAction((Encounter encounter)=>
        {
            Environment.Exit(7);
        })),new ActionButton("Another Action",new ActionButton.DoAction((Encounter encounter)=>
        {
            Environment.Exit(7);
        }))});

        public string title;
        public string prompt;
        public List<ActionButton> actions;

        public Encounter(string title, string prompt,List<ActionButton> actions)
        {
            this.title = title;
            this.prompt = prompt;
            this.actions = actions;
        }
    }
}
