using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=0;
            int primeCount = 0;
            int primeSum = 0;
            Console.WriteLine("Please Enter 3 Numbers to Check if PRIME. If all numbers are PRIME you will recieve a Sum");
            while (j < 3)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (CheckPrime(b))
                {
                    j++;
                    primeCount++;
                    primeSum = primeSum + b;
                }
                else
                {
                    j++;
                }
            }
            if (primeCount == 3)
            {
                Console.WriteLine($"The sum of your PRIME Numbers is {primeSum}");
            }
            else
            {
                Console.WriteLine("atleast 1 of the numbers was not prime");
            }
        }

        private static bool CheckPrime(int a)
        {
            int i = 2;
            while (a % i != 0 && i < a)
            {
                i++;
            }
            if (a == i)
            {
                Console.WriteLine("PRIME");
                return true;
            }
            else
            {
                Console.WriteLine("Not Prime");
                return false;
            }
        }
    }
}
