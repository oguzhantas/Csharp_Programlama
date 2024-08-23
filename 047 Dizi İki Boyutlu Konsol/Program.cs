using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_Dizi_İki_Boyutlu_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notlar = new int[4, 3];
            double toplam=0, ortalama=0;
            //4 satır(öğrenci) ve 3 sütun(her öğrencinin 3 notu var) 
            for(int i = 0; i < 4; i++) //öğrenci sayısı kadar döner
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write((i+1)+".öğrencinin "+(j+1)+".notu: ");
                    notlar[i,j]= int.Parse(Console.ReadLine());
                    toplam += notlar[i, j];
                }
                ortalama = toplam / 3;
                Console.WriteLine("Ortalama:" + ortalama);
                toplam = 0;
                ortalama=0; 
            }
            Console.ReadKey();

        }
    }
}
