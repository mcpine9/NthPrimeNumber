using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber prime = new PrimeNumber();
            Console.WriteLine("10,001st prime number is: {0}", prime.GetNthPrimeNumber(10001));
            Console.ReadLine();
        }
    }
}
