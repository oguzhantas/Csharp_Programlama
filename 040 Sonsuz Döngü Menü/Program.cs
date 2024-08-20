using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_Sonsuz_Döngü_Menü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("A) Toplama");
                Console.WriteLine("B) Çıkarma");
                Console.WriteLine("C) Bölme");
                Console.WriteLine("D) Çarpma");
                Console.WriteLine("X) ÇIKIŞ");
                Console.WriteLine("X) ÇIKIŞ");
                Console.Write("Seçiminiz:");
                char secim = char.Parse(Console.ReadLine());
                int s1=0, s2=0, sonuc;
                if (!(secim == 'x' || secim == 'X'))
                {
                    Console.Write("1. sayı giriniz:");
                    s1 = int.Parse(Console.ReadLine());
                    Console.Write("2. sayı giriniz:");
                    s2 = int.Parse(Console.ReadLine());
                }

                if (secim == 'A' || secim == 'a')
                {
                    Console.WriteLine("Toplam seçildi");
                    sonuc = s1 + s2;
                    Console.WriteLine("Sonuç:"+sonuc);
                    Console.ReadKey();
                }
                else if (secim == 'B' || secim == 'b')
                {
                    Console.WriteLine("Çıkarma seçildi");
                    sonuc = s1 - s2;
                    Console.WriteLine("Sonuç:" + sonuc);
                    Console.ReadKey();
                }
                else if (secim == 'C' || secim == 'c')
                {
                    Console.WriteLine("Bölme seçildi");
                    if (s2 != 0)
                    {
                        sonuc = s1 / s2;
                        Console.WriteLine("Sonuç:" + sonuc);
                        Console.ReadKey();
                    }
                        
                    else
                        Console.WriteLine("Sıfıra bölünemez");
                }
                else if (secim == 'D' || secim == 'd')
                {
                    Console.WriteLine("Çarpma seçildi");
                    sonuc = s1 * s2;
                    Console.WriteLine("Sonuç:" + sonuc);
                    Console.ReadKey();
                }
                else if (secim == 'X' || secim == 'x')
                {
                    Console.WriteLine("Çıkıldı");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Lütfen A,B,C,D,X seçeneklerinden birisini giriniz");
                }


            } //while sonsuz döngü

           
            Console.ReadKey();
        }
    }
}
