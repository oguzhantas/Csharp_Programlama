using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_For_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0.1, 0.2, 0.3, ... 1
            for(double i=0; i<=1; i += 0.1)
            {
                if (i == 0.5) break;
                Console.WriteLine(i);
            }
            Console.ReadKey(); 
        }
    }
}
