using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Dort_Islem
{
{
    internal class Program
    {
        static double topla(double x, double y) {
            return (x+y);
        }

        static double carp(double x, double y)
        {
            return (x*y);
        }

        static double cikar(double x, double y)
        {
            return (x - y);
        }

        static double bolme(double x, double y)
        {
            double sonuc;
            if (y == 0)
            {
                Console.WriteLine("Sıfıra bölünemez");
                return 0;
            }
            else
                return (x / y);
        }

        static void Main(string[] args)
        {

            double a, b;
            Console.Write("1. sayıyı giriniz:");
            a= double.Parse(Console.ReadLine());

            Console.Write("2 sayıyı giriniz:");
            b = double.Parse(Console.ReadLine());


            double toplamSonucu = topla(a, b);
            double carpimSonucu= carp(a, b);
            double bolumSonucu= bolme(a, b);
            double cikarimSonucu = carp(a, b);
            Console.WriteLine("Toplam sonucu:"+toplamSonucu);
            Console.WriteLine("Çarpım sonucu:" + carpimSonucu);
            Console.WriteLine("Bölüm sonucu:" + bolumSonucu);
            Console.WriteLine("Çıkarım sonucu:" + cikarimSonucu);
            Console.ReadKey();
        }
    }
}
