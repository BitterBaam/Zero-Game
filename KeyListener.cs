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
                    if(keyinfo.Key == ConsoleKey.Escape)
                    {
                        tjekking = false;
                    }
                }
                if(Program.CurrentMap == WorldGen.map)
                {
                    WorldGen.listen();
                }
                if(Program.CurrentMap == WorldGen.map && keyinfo.Key == ConsoleKey.Escape)
                {
                    Program.CurrentMap = Menu.map;
                    Screen.print();
                }
            }
            while (tjekking);
        }
    }
}