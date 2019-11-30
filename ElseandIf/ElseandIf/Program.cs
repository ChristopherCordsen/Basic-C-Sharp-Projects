using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseandIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number!";

            Console.WriteLine(result);
            Console.ReadLine();


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are at?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.Write("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhh... Something went wrong!");
            //}
            //Console.ReadLine();

            //int currentTemperature = 90;
            //int roomTemperature = 95;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room Temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > roomTemperature)
            // {
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            // }
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            Console.ReadLine();
        }
    }
}
