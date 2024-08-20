using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_Sonsuz_Döngü_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.Clear();

            for (i=0 ; ;i++)
            {
                Console.WriteLine(i);
                if (i == 10) break;
            }
            Console.WriteLine("Döngüden çıkıldı");
            Console.ReadKey();
        }
    }
}
