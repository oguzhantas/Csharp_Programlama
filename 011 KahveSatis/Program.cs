using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_KahveSatis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim=1, adet=1, toplam=0;

            Console.WriteLine("1) Latte 100 TL");
            Console.WriteLine("2) Americano 70 TL");
            Console.WriteLine("3) Machiato 110 TL");
            Console.WriteLine("4) Filtre 60 TL");

            Console.Write("Seçiminiz:");
            secim = int.Parse(Console.ReadLine());
            if(secim>=1 && secim<=4)
            {
                Console.Write("Kaç adet:");
                adet = int.Parse(Console.ReadLine());

                //Secim 1 ile 4 arasında girilmişse bu kısım işletilecek
                if (secim == 1)
                {
                    toplam = adet * 100;
                }
                else if (secim == 2)
                {
                    toplam = adet * 70;
                }
                else if (secim == 3)
                {
                    toplam = adet * 110;
                }
                else if (secim == 4)
                {
                    toplam = adet * 60;
                }

            }
            else
            {
                //Secim 1 ile 4 arasında değilse bu kısım işletilecek
                Console.WriteLine("1 ile 4 arasında seçim yapınız");
            }

            Console.WriteLine("Toplam Ödenecek:" + toplam.ToString());
            Console.ReadKey(); 

        }
    }
}
