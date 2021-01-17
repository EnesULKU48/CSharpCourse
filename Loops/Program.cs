using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {  //int i = 1; başlangıcı & i <= 100; şartı olduğu sürece & i++ bir döngü bittiğinde ne yapayım
           // (int i = 100; i >= 0; i=i-2) 
           //ForLoops();
           //i++ bir bir arttır (i=i+2) tek (i+=2) tek
           //WhileLoops();
           //DoWhileLoops();
           //ForeachLoops();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number" );
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForeachLoops()
        {
            string[] students = new string[3] { "Enes", "Mustafa", "İbrahim" };
            foreach (var student in students) //dizinin tüm elemanlarını tek tek gezer
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoops()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoops()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;  //-- bir bir azaltınca sayı 0a geliyor ve döngü durur
            }
            Console.WriteLine("Now number is {0} ", number);
        }

        private static void ForLoops()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
