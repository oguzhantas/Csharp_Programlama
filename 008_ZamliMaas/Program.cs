using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ZamliMaas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maas, zam, zamlimaas;
            
            Console.Write("Maaşınızı giriniz:");
            maas= double.Parse(Console.ReadLine());

            zam = maas * 10 / 100;
            zamlimaas = zam + maas;
            Console.WriteLine("Yeni maaşınız:"+zamlimaas+"\nZam miktarı:"+zam);
            Console.ReadKey();

        }
    }
}
