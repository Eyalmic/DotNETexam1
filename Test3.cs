using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.Write("1");

                for (int z = 2; z <= i; z++)
                {
                    Console.Write(z);
                }

                for (int j = a; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
