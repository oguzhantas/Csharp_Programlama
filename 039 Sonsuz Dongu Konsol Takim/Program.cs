using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Sonsuz_Dongu_Konsol_Takim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("KIRMIZI");
                }
                     
                else if (i % 2 == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Beyaz");
                }
                   

                i++;
                if (i == 100) break;
            }
            Console.ReadKey();
        }
    }
}
