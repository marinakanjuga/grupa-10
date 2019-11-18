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
            double? num = null;
            double? num1 = 3.15;
            double? numr;

            numr = num ?? 5;//numr ce biti num, a u slucaju da je num null, onda ce biti 5 (ili moze num1)

            if (num == null) //ovo je zamena za num ??
            {
                numr = num1;
            }
            else 
            {
                numr = num;
            }

            //ternarni operator
            numr = (num < 10) ? 10 : num1;
            
            
            
            Console.WriteLine("rezulatat {0}", numr);
            Console.ReadKey();          
        }    
    }
}


