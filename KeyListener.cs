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
                else if(Program.CurrentMap == Menu.map2)
                {
                    Menu.listen2();
                }
                else if (Program.CurrentMap == WorldGen.map)
                {
                    WorldGen.listen();
                }
                if(Program.CurrentMap == WorldGen.map && keyinfo.Key == ConsoleKey.Escape)
                {
                    Program.CurrentMap = Menu.map;
                    Screen.print();
                }
            }
        }
    }
}