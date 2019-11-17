using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas19
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
           //da prodje kroz petlju 10 puta i da sabere sve vrednosti tog brojaca, suma brojaca, da krene od 1
            for (int a = 1; a <= 10; a++) 
            {
                Console.WriteLine(a);
                suma = suma + a;             
            }
          
            Console.WriteLine(suma);
            Console.ReadKey();
        }
       
    }
}


