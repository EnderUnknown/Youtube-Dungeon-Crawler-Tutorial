using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public static class RandomHelper
    {
        public static Random rand = new Random();

        public static int DoRoll(int faces, int quantity = 1)
        {
            int counter = 0;
            for (int i = 0; i < quantity; i++)
                counter += rand.Next(1, faces + 1);
            return counter;
        }
    }
}
