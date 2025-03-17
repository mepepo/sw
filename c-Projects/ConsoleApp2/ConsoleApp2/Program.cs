using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVEDITE CHUIISLO:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                Console.WriteLine($"vi vveli chislo: {number}");
       
            }
            else

            {
                Console.WriteLine("oshibka: vvedeniy daniye  ne yt chislo");
                Console.ReadLine();
            }

        }
    }
}
