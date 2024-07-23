using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Hesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilo;
            double kilofiyat;
            double toplam;

            //Convert.ToInt ile string bilgiyi int türüne çeviriyoruz.
            Console.Write("Kilosunu giriniz:");
            kilo = Convert.ToInt32( Console.ReadLine());
            //kilo= int.Parse( Console.ReadLine()) ;

            //Convert.ToDouble ile string bilgiyi double türüne çeviriyoruz.
            Console.Write("Kilo fiyatını giriniz:");
            kilofiyat = Convert.ToDouble(Console.ReadLine());
           // kilofiyat= double.Parse(Console.ReadLine());

            toplam= kilo*kilofiyat;
            Console.WriteLine("Toplam ödenecek:" + toplam);
            Console.ReadKey();

        }
    }
}
