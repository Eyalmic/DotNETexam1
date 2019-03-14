using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seconds to calculate in DD//HH//MM//SS format");
            int secondsTotal = Convert.ToInt32(Console.ReadLine());
            int b = secondsTotal;

            int days = secondsTotal / 86400;
            secondsTotal = secondsTotal % 86400;

            int hours = secondsTotal / 3600;
            secondsTotal = secondsTotal % 3600;

            int minutes = secondsTotal / 60;
            secondsTotal = secondsTotal % 60;

            Console.WriteLine($"{b} seconds amount to {days} days, {hours} hours, {minutes} minutes, {secondsTotal} seconds");
        }
    }
}
