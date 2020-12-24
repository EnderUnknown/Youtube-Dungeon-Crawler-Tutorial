using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Damage
    {
        public int amount;
        public string type;

        public Damage(int amount, string type = "kinetic")
        {
            this.amount = amount;
            this.type = type;
        }
    }
}
