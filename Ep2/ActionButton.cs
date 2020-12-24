using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class ActionButton
    {
        public delegate void DoAction(Encounter encounter);

        public string title;
        public DoAction action;

        public ActionButton(string text, DoAction onClick)
        {
            title = text;
            action = onClick;
        }

        public void DoClick(Encounter encounter)
        {
            action.Invoke(encounter);
        }
    }
}
