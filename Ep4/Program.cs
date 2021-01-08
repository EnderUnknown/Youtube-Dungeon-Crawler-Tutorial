using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler
{
    static class Program
    {

        public static Game gameInstance;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gameInstance = new Game();
            GameEngine.instance = new GameEngine(gameInstance);
            Application.Run(gameInstance);
        }
    }
}
