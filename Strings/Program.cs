using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Enes Ülkü";
           
            var result = sentence.Length; // sentence=cümle length=uzunluk
            var result2 = sentence.Clone();
            //sentence = "My name is Mustafa";

            bool result3 = sentence.EndsWith("a");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");//bulamazsa -1 bulursa kaçıncı karakterden başlayacağı
            var result6 = sentence.IndexOf(" ");// aramaya baştan başlar
            var result7 = sentence.LastIndexOf(" ");// aramaya sondan başlar
            var result8 = sentence.Insert(0,"Hello, ");//stringe karakter eklemek için kullanılır
            //(0,"Hello ") stringin kaçıncı karakterinden başlayacağını belirle ve yaz
            var result9 = sentence.Substring(3,4);// metni parçalamak demek 3. karakterden 4 tane al
            var result10 = sentence.ToLower();//hepsini küçük yapar
            var result11 = sentence.ToUpper();//hepsini büyük yapar
            var result12 = sentence.Replace(" ","-");//boşluk yerine -
            var result13 = sentence.Remove(2,4);//den sonrasını kaldır

            Console.WriteLine(result5);
            //Console.WriteLine(result4);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "ANKARA";
            //Console.WriteLine(city [0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İSTANBUL";
            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
