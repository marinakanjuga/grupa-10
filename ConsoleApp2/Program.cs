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
            CalculateValue();
            
            Console.ReadKey();          
        }
        static void CalculateValue () 
        {
            int[] clanovi = new int[10];
            int[] stanje = { 125, 23 };
            int[] poeni = new int[3] { 1, 2, 3 };

            for (int i = 0; i < 10; i++)
            {
                clanovi[i] = i * 10;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vrednost elemenata clanovi {0} = {1}", i, clanovi[i]);
            }
            foreach (int clan in clanovi)
            {
                Console.WriteLine("vrednost elemenata clanovi {0}", clan);
            }
            Console.WriteLine("sum of all elements is {0}", CalculateSum(clanovi));
            Console.WriteLine("sum of all elements is {0}", CalculateSumForeach(clanovi));
            int rezult = CalculateArray(1, 2, 3, 4);
            Console.WriteLine("sum of all elements is {0}", rezult);
        }
        static int CalculateArray(params int[] num)
        //static int CalculateArray(int[] num1, int[] num2) - ovo je isto
        {
            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
            }
            return sum;
        }
        static int CalculateSum(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
        static int CalculateSumForeach(int[] num)
        {
            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
            }
            return sum;
        }
    }
}


