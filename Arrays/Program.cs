using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] students = new string[4]; // [] tek boyutlu dizi demek (arrays) 
            //students[0] = "Enes";
            //students[1] = "Mustafa";
            //students[2] = "İbrahim";

            //string[] students2 = { "Enes", "Mustafa", "İbrahim" }; //= new[]    

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            //string[] students = new string[3] { "Enes", "Mustafa", "İbrahim" };

            string[,] regions = new string[5, 3] // 5 satır 3 kolon
            {
                    { "İstanbul", "Kocaeli", "Balıkesir" },
                    { "Ankara", "Konya", "Eskişehir" },
                    { "Antalya", "Adana", "Mersin" },
                    { "Rize", "Trabzon", "Samsun" },
                    { "Muğla", "İzmir", "Aydın" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //satırlar0 sütunlar1
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }



            Console.ReadLine();

        }
    }
}


