using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Damage
    {
        public static Damage NONE = new Damage(-1);

        public int amount;
        public string type;

        public delegate int GetDamage();

        public Damage(int amount, string type = "kinetic")
        {
            this.amount = amount;
            this.type = type;
        }
    }
}
