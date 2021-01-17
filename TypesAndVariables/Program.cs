using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //Console.WriteLine("Hello World");
            double number5 = 10.55; //64 bitlik ondalık sayılar virgülden 15 tane karakter
            decimal number6 = 1.42m; // 'm'konulması zorunlu ondalık sayılar virgülden sonra 28 karakter

            int number1 = 2147483647; //32 bitlik tam sayı
            long number2 = 2147483648; //64 bitlik tam sayı
            short number3 = 23767; //16 bitlik tam sayı
            byte number4 = 255; //8 bitlik tam sayı
            bool condition = true;
            char character = 'A';
            var number7 = 10;
            number7 = 'B';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("character is : {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine(Days.Monday); // (int)
            Console.ReadLine();
        }

    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday // =ile farklı değerler verilebilir 
    }
}
