using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero_Game
{
    class tilePath
    {
        public static Char Char { get; set; }

        public static void Place(int mapPos)
        {
            try
            {
                WorldGen.map[mapPos] = Char;
            }
            catch(IndexOutOfRangeException e)
            {

            }
        }
    }
}
