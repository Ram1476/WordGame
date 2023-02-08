using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WrdGame player1 = new WrdGame();
            player1.Gamerules();

            Console.WriteLine($"\n********************\n{player1.Startgme()}");
            Console.WriteLine("\n********************");

            Console.ReadLine();
        }
    }
}
