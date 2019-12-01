using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNumber = number == 420;

            do
            {
                switch (number)
                {
                    case 93:
                        Console.WriteLine("Your guessed 93. try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("Your guessed 69. try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 82:
                        Console.WriteLine("Your guessed 82. try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 420:
                        Console.WriteLine("Your guessed 420. that is correct.");
                        guessedNumber = true;
                        break;
                    default:
                        Console.WriteLine("You are very wrong!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessedNumber);

            Console.ReadLine();
        }
    }
}
