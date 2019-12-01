using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Christopher";
            string quote = "Christopher, \n is, doing something different in \n \t April";
            string fileName = @"C:\User\Christopher\Programs";

            Console.WriteLine(fileName);
            Console.ReadLine();         

            //********************Stringbuilder, build a paragraph of text***********
            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Christopher");
            //sb.Append(" and in April I am going to be doing");
            //sb.Append(" something different and I am very excited.");

            //Console.WriteLine(sb);
            //Console.ReadLine();



            //********************String to Upper*********************************
            //string name = "Christopher";

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();
        }
    }
}
