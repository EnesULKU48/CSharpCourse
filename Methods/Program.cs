using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //add();
            //add();
            //var result = add2(25);

            //int number1 = 20; // =20
            //int number2 = 100;
            //var result2 = add3(number1, number2); //değer tipleri sadece değişkenin değeriyle ilgilenir
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Multiply(4,7));
            Console.WriteLine(add4(5,4,8,6,1));
            Console.ReadLine();
        }

        static void add()    
        {
            Console.WriteLine("Added!!");
        }

        static int add2(int number1, int number2 = 30) // default parametresi sondan yazılır
        {
            var result = number1 + number2;
            return result;
        }

        static int add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        static int Multiply(int number1,int number2,int number3) //Multiply çarpmak demek
        {
            return number1 * number2 * number3;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int add4(params int[] numbers)//params ile metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz
        {
            return numbers.Sum();
        }
    }
}
