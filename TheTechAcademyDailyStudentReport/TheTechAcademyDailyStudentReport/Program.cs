using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTechAcademyDailyStudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Student Report");
            Console.ReadLine();


            // Questions to ask
            //What course are you on?
            //What page number?
            //Do you need help with anything? Please answer “true” or “false”.
            //Were there any positive experiences you’d like to share? Please give specifics.
            //Is there any other feedback you’d like to provide? Please be specific.
            //How many hours did you study today?
            // after print “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” 

            Console.WriteLine("What course are on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
           
            Console.WriteLine("Do you need help with anything? Please answer True or False!");
            //bool needHelpT = true;
            //string needHelpTrue = Convert.ToString(needHelpT);
            //Console.WriteLine(needHelpTrue);
            //Console.ReadLine();
            
            string needHelp= Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
           


            //Answers to Questions 
            Console.WriteLine("Your Answers!");
            Console.WriteLine("  "+ cou
                rse );
            Console.WriteLine(" " + pageNumber);
            Console.WriteLine(" "+ needHelp);
            Console.WriteLine(" " + positiveExperiences);
            Console.WriteLine(" " + feedback); 
            Console.WriteLine(" " + hoursStudy);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}