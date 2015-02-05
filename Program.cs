using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace Zero_Game
{
    class Program
    {
        public static string[] CurrentMap;
        public static string SelectChar;
        public static string SelectChar2;

        static void Main(string[] args)
        {
            
            InitGame();
            CurrentMap = Menu.map;
            Screen.print();
            KeyListener.Listen();


 
        }
        private static void InitGame()
        {
            Player.Position = 840;
            Player.Char = "P";
            tilePath.Char = "#";
            tileEnemy.Char = "E";
            SelectChar = "]";
            SelectChar2 = "[";
            Menu.map[600] = SelectChar;
            Menu2.map[600] = SelectChar;
            Menu.map[595] = SelectChar2;
            Menu2.map[590] = SelectChar2;
            WorldGen.map[Player.Position] = Player.Char;
            KeyListener.tjekking = true;
        }
        public static void SaveGame()
        {
            string FileName = "WorldGenMap";
            try
            {
                StreamWriter save = new StreamWriter(FileName + ".txt", false);
                foreach (string i in WorldGen.map)
                {
                    save.Write(i);
                }
                save.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void LoadGame()
        {
            string FileName = "WorldGenMap.txt";
            try
            {
                StreamReader read = new StreamReader(FileName);
                Console.WriteLine((char)read.Peek());
                read.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
