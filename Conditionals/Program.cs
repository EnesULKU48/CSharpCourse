﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 55;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}


            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            if (number < 100)
            {
                if (number >= 50 && number <= 100)
                {
                    Console.WriteLine("Number is between 50-100");
                }
                else if (number < 50 && number >= 0)
                {
                    Console.WriteLine("Number is between 0-50");
                }
                else //(number < 0 || number > 100)
                {
                    Console.WriteLine("Number is less than 0 or greater than 200");
                }
            }

            Console.ReadLine();
        }
    }
}
//var number = 11;
//Console.WriteLine(number == 10 ? "sayı 10" : "sayı 10 değil");
//Console.ReadLine();