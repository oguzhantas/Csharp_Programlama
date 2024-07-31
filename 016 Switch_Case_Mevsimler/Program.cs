using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Switch_Case_Mevsimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) İlkbahar");
            Console.WriteLine("2) Yaz");
            Console.WriteLine("3) Sonbahar");
            Console.WriteLine("4) Kış");
            Console.Write("Seçiminiz:");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1: Console.WriteLine("Mart Nisan Mayıs"); break;
                case 2: Console.WriteLine("Haziran Temmuz Ağustos"); break;
                case 3: Console.WriteLine("Eylül Ekim Kasım"); break;
                case 4: Console.WriteLine("Aralık Ocak Şubat"); break;
                default: Console.WriteLine(" 1-4 arası sayı giriniz"); break;
            }
            Console.ReadKey();

        }
    }
}
