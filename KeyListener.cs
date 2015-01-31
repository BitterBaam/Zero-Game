using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero_Game
{
    class KeyListener
    {
        public static Boolean tjekking;
        public static ConsoleKeyInfo keyinfo;

        public static void Listen()
        {
            do
            {
                keyinfo = Console.ReadKey();
                if (Program.CurrentMap == Menu.map)
                {
                    Menu.listen();
                }
                if(Program.CurrentMap == WorldGen.map)
                {
                    WorldGen.listen();
                }

            }
            while (keyinfo.Key != ConsoleKey.Escape && tjekking);
        }
    }
}