using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Zero_Game
{
    class KeyListener
    {
        public static Boolean tjekking;
        public static ConsoleKeyInfo keyinfo;

        public static void Listen()
        {
            while (tjekking)
            {
                keyinfo = Console.ReadKey();
                if (Program.CurrentMap == Menu.map)
                {
                    Menu.listen();
                }
                else if(Program.CurrentMap == Menu2.map)
                {
                    Menu2.listen();
                }
                else if (Program.CurrentMap == WorldGen.map)
                {
                    WorldGen.listen();
                }
            }
        }
    }
}