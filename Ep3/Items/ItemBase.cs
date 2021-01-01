using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public class ItemBase
    {
        public string name;
        public string desc;

        public ItemBase(string name)
        {
            this.name = name;
        }

        public virtual List<EncounterAction> GetCombatActions()
        {
            return null;
        }
    }
}
