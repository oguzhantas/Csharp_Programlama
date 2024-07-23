using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_KlavyedenOkuma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string adi, soyadi;
            
            Console.Write("Adınızı giriniz:");
            adi = Console.ReadLine();
            
            Console.Write("Soyadınızı giriniz:");
            soyadi = Console.ReadLine();

            string mesaj = "Sayın " + adi + " " + soyadi + " Hoş geldiniz.";
            Console.WriteLine(mesaj);
            Console.ReadKey();
        }
    }
}
