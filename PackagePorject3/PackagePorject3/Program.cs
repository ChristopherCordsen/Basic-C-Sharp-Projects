using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackagePorject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight >= 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());


            int total = packageLength + packageHeight + packageWidth;

            if (total >= 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            int otherTotal = total * packageWeight;
            double otherOtherTotal = otherTotal / 100.00;
            Console.WriteLine("Your estimated total for shipping this package is: $" + otherOtherTotal);
            Console.WriteLine("Thank You!");
            Console.ReadLine();

            //if (packageWeight >= 50)
            //{
            //    Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            //    Console.ReadLine();
            //    return;

            //}
            //if (total >= 50)
            //    Console.WriteLine("Package is too big to be shipped via Package Express.");
            //    Console.ReadLine();
            //    return;

        } 
    }
}