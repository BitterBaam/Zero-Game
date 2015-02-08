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
        public static Char[] CurrentMap;
        public static Char SelectChar;
        public static Char SelectChar2;

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
            Player.Char = 'P';
            tilePath.Char = '#';
            tileEnemy.Char = 'E';
            SelectChar = ']';
            SelectChar2 = '[';
            Menu.map[600] = SelectChar;
            Menu2.map[600] = SelectChar;
            Menu.map[595] = SelectChar2;
            Menu2.map[590] = SelectChar2;
            WorldGen.map[Player.Position] = Player.Char;
            KeyListener.tjekking = true;
        }
        public static void SaveGame()
        {
            string FileName = "WorldGen";
            try
            {
                StreamWriter saveMap = new StreamWriter(FileName + "map.txt", false);
                StreamWriter savePos = new StreamWriter(FileName + "PlayerPos.txt", false);
                foreach (Char i in WorldGen.map)
                {
                    saveMap.Write(i);
                }
                savePos.Write(Player.Position);
                saveMap.Close();
                savePos.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void LoadGame()
        {
            string FileName = "WorldGen";
            try
            {
                int i = 0;
                StreamReader readMap = new StreamReader(FileName + "Map.txt");
                StreamReader readPlayerPos = new StreamReader(FileName + "PlayerPos.txt");
                while (readMap.Peek() >= 0)
                {
                    WorldGen.map[i] = ((char)readMap.Read());
                    i++;
                }
                Player.Position = Convert.ToInt32(readPlayerPos.ReadToEnd());
                Program.CurrentMap = WorldGen.map;
                Screen.print();
                readMap.Close();
                readPlayerPos.Close();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
