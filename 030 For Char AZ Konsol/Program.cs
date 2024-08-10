using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_For_Char_AZ_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (i == 'c') continue;
                if (i == 'c') continue;
                if (i == 'c') continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
