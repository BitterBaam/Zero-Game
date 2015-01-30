using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Zero_Game
{
    class Program
    {
        public static string[] CurrentMap;
        public static string SelectChar;

        private static Boolean Going = false;
        static void Main(string[] args)
        {
            
            Going = true;
            InitGame();
            CurrentMap = Menu.map;
            Screen.print();
            KeyListener.Listen();


 
        }
        private static void InitGame()
        {
            Player.Position = 5;
            Player.Char = "P";
            tilePath.Char = "#";
            SelectChar = "#";
            WorldGen.map[Player.Position] = Player.Char;
            KeyListener.tjekking = true;

            int count = 0;
            foreach(string i in WorldGen.map)
            {
                if(count != Player.Position)
                {
                    WorldGen.map[count] = "#";
                }
                count++;
            }
        }
    }
}
