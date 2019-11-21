using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            Console.WriteLine("32");
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("False");
            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine("1");
            Console.ReadLine();
            Console.WriteLine("Qualified?");

            int yourAge = 32;
            bool haveDUI = false;
            int speedingTicket = 1;

            bool qualifiedInsurance = (yourAge > 15 || speedingTicket > 1 || haveDUI);
            
            Console.WriteLine(qualifiedInsurance);
            Console.ReadLine();
        }
    }
}
