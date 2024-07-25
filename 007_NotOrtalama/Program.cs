using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_NotOrtalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double not1, not2, not3, ortalama;

            Console.Write("1. notu giriniz:");
            not1 = double.Parse(Console.ReadLine());

            Console.Write("2. notu giriniz:");
            not2 = double.Parse(Console.ReadLine());

            Console.Write("3. notu giriniz:");
            not3 = double.Parse(Console.ReadLine());

            ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalama:"+ortalama);
            Console.ReadKey();
        }
    }
}
