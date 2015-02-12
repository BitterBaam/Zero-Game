using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zero_Game
{
    class tileEnemy
    {
        public static Char Char { get; set; }
        public static List<int> Enemies = new List<int>();
        public static void Place(int mapPos)
        {
            try
            {
                WorldGen.map[mapPos] = Char;
            }
            catch (IndexOutOfRangeException e)
            {

            }
        }
        public static void Save(int mapPos)
        {
            Enemies.Add(mapPos);
            string FileName = "enemy";
            try
            {
                StreamWriter saveEnemy = new StreamWriter(FileName + ".txt", false);
                foreach (int i in Enemies)
                {
                    saveEnemy.Write(i);
                    saveEnemy.Write(",");
                }
                saveEnemy.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
