using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Sart_Kullanici_Sifre_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullaniciadi="", sifre="";

            Console.Write("Kullanıcı adınızı giriniz:");
            kullaniciadi= Console.ReadLine();

            Console.Write("Şifre giriniz:");
            sifre= Console.ReadLine(); 

            if(kullaniciadi=="oguz" && sifre=="1234")
            {
                Console.WriteLine("Başarıyla giriş yaptınız");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            }

            Console.ReadKey();
        }
    }
}
