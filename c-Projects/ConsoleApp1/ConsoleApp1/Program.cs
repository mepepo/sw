using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 123.456789;
            double roundedNumber = Math.Round(number, 2);
            Console.WriteLine(roundedNumber.ToString("F2"));

        }
    }
}
