using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            PayRateCalculator payCheck = new PayRateCalculator();
            Console.Write("Person1");
            payCheck.personOne = Console.ReadLine();
            Console.Write("Hourly Rate? ", payCheck.personOne);
            payCheck.payrate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours worked per week? ", payCheck.personOne);


            payCheck.hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}Weekly Salary of Person1 ${1}", payCheck.personOne, payCheck.grossPay);
            Console.ReadLine();

        }
    }
}
