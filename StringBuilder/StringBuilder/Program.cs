﻿using System;
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
            //string name = "Christopher";
            //string quote = "The man said, \"hello\", Chritopher. \n Hello on a new line! \n \t hello on a tab!";
            //string fileName = @"C\\User\\Christopher";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //int = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();
            //string name = "Christopher";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Christopher");
            sb.Append(" and in April I am going to be doing");
            sb.Append(" something different and am excited.");


            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
