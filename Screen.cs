using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zero_Game
{
    class Screen
    {
        public static void print()
        {
            Console.Clear();
            foreach (char i in Program.CurrentMap)
            {
                Console.Write(i);
            }
        }
    }
}
