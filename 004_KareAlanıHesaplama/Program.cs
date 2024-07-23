using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanıHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int cevre = a * 4;
            int alan = a * a;
            Console.WriteLine("Karenin alanı:"+alan);
            Console.WriteLine("Karenin çevresi:"+cevre);
            Console.ReadKey();
        }
    }
}
