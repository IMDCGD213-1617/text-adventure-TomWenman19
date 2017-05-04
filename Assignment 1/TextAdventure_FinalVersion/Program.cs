using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {


        static void Main(string[] args)
        {
            Game Game1 = new Game();

            //start our game loop - we keep running this function until the player quits.
            while (Game1.isRunning)
            {
                Game1.Update();
            }
        }
    }
}
