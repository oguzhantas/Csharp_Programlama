using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _13_Sart_Yapilari_VEYA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int yas;
            char cinsiyet; // Erkek ise 'E' veya 'e', Kadın ise 'K' veya 'k

            Console.Write("Cinsiyetinizi giriniz:"  );
            cinsiyet = char.Parse(Console.ReadLine());

            Console.Write("Yaşınızı giriniz:");
            yas= int.Parse(Console.ReadLine());

            //Kadın 58, erkek 60
            if (cinsiyet == 'E' || cinsiyet == 'e')
            {
                if (yas >= 60)
                    Console.WriteLine("Emekli olabilirsiniz");
                else
                    Console.WriteLine("Emekli olmak için " + Math.Abs(yas - 60) + "  yılınız var");
            }
            else if (cinsiyet == 'K' || cinsiyet == 'k') {

                if (yas >= 58)
                    Console.WriteLine("Emekli olabilirsiniz");
                else
                    Console.WriteLine("Emekli olmak için " + Math.Abs(yas - 58) + "  yılınız var");
            } 
            else if (!(cinsiyet=='E' || cinsiyet =='e' || cinsiyet =='K' || cinsiyet=='k'))
            {
                Console.WriteLine(" K veya E harflerini yazınız");
            }
            Console.ReadKey();
        }
    }
}
