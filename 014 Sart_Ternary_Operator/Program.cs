using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Sart_Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dönemsonu notunu giriniz: ");
            double sonnot= double.Parse(Console.ReadLine());

            string sonuc;
             sonuc = (sonnot >= 50) ? "Geçti" : "Kaldı";
           /* if (sonnot >= 50)
                sonuc = "Geçti";
            else
                sonuc = "Kaldı";
           */
            Console.WriteLine(sonuc);
            Console.ReadKey();

        }
    }
}
