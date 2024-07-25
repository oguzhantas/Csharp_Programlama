using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Sart_Suyun_Kaynamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 derece ve altında su donar
            //1-99 sıvı halde
            //100 ve üstü ise gaz halindedir, buharlaşır

            double sicaklik;
            Console.Write("Sıcaklık giriniz:");
            sicaklik= double.Parse(Console.ReadLine());

            if (sicaklik <= 0) {
                Console.WriteLine("Su katı halde, buz durumunda");
            }
            else if(sicaklik>=1 && sicaklik<=99) {
                Console.WriteLine("Su sıvı  halde");
            } 
            else if (sicaklik >= 100)
            {
                Console.WriteLine("Su gaz halinde, buhar durumunda");
            }
            Console.ReadKey();
        }
    }
}
