using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Indirim_Yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fiyat, indirimOran, indirimliFiyat;
            Console.Write("Ürün fiyatı:");
            fiyat = double.Parse(Console.ReadLine());

            Console.Write("İndirim oranı(%):");
            indirimOran = double.Parse(Console.ReadLine());

            indirimliFiyat = fiyat - indirimOran * fiyat/100;
            Console.WriteLine("İndirimli fiyat:"+indirimliFiyat);

            Console.ReadKey();
         }
    }
}
