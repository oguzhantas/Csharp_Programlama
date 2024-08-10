using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_For_Continue_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 10; i++)
            {
                if(i%2==0) continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
