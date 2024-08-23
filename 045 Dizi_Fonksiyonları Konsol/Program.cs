using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_Dizi_Fonksiyonları_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] araclar = { "BMW", "Mercedes", "Audi", "Volkswagen" };
            araclar[3] = "Lombargini";

            Array.Clear(araclar, 1, 2);
       
           for (int i = 0; i < araclar.Length; i++)
            {
                Console.WriteLine(araclar[i]);
            }
            Console.ReadKey();
        }
    }
}
