using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Sart_Gunaydin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saat;
            Console.Write("Günün saatini giriniz:");
            saat = int.Parse(Console.ReadLine());

            if (saat >= 6 && saat < 12)
                Console.WriteLine("Günaydın");
            else if (saat >= 12 && saat <17)
                Console.WriteLine("Tünaydın");
            else if (saat >= 17 && saat < 20)
                Console.WriteLine("İyi akşamlar");
            else if (saat >= 20 && saat < 24)
                Console.WriteLine("İyi geceler");
            else if (saat >= 0 && saat < 6)
                Console.WriteLine("İyi uykular");

            Console.ReadKey();

        }
    }
}
