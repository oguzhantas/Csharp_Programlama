using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Sart_Ehliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.Write("Yaş giriniz:");
            yas= int.Parse(Console.ReadLine());

            if (yas >= 18)
                Console.WriteLine("Ehliyet alabilirsiniz");
            else
                Console.WriteLine("Ehliyet almak için " + (18 - yas) + " yıl beklemelisiniz");

            Console.ReadKey();
        }
    }
}
