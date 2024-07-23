using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3; //Tamsayı a değişkeni tanımlama
            int b=4; //Tamasayı b değişkeni tanımlama

            int toplam = a + b; //toplayıp toplam değişkenine aktarma
            int cikarma = a - b;
            double bolme = (double)a / b; //Zorunlu tip dönüşümü yapıldı
            int carpma = a * b;

            Console.WriteLine("Toplam sonucu :"+toplam); //Toplamı Ekrana yazdırma
            Console.WriteLine("Çıkarım sonucu :" + cikarma); //Çıkarımı Ekrana yazdırma
            Console.WriteLine("Bölme sonucu :" + bolme); //Bölme Ekrana yazdırma
            Console.WriteLine("Çarpma sonucu :" + carpma); //Çarpma Ekrana yazdırma

            Console.ReadKey(); //Ekranı bekletme
        }
    }
}
