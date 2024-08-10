using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_For_ile_Toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for(int i = 1; i <= 100; i++)
            {
                toplam = toplam + i; 
                //toplam=0+1=1
                //toplam=1+2=3
                //toplam=3+3=6
                //toplam=6+4=10
                //toplam=10+5=15
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
