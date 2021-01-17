using System;

namespace E_Ticaret
{
    class Program
    {
        public static string Marka { get; private set; }

        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Marka = "Apple";
            Urun1.Model = "Iphone xs max";
            Urun1.Hafıza = "128 GB";
            Urun1.Fiyat = "14000 TL";

            Urun Urun2 = new Urun();
            Urun2.Marka = "Xioami";
            Urun2.Model = "Mi Note 10 Lite";
            Urun2.Hafıza = "128 GB";
            Urun2.Fiyat = "4500 TL";

            Urun Urun3 = new Urun();
            Urun3.Marka = "Vestel";
            Urun3.Model = "Z 40";
            Urun3.Hafıza = "128 GB";
            Urun3.Fiyat = "2500 TL";

            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3};

            Console.WriteLine("*****foreach*****");
            foreach (var kurs in Urunler)
            {
                Console.WriteLine("Marka : " + kurs.Marka);
                Console.WriteLine("Model : " + kurs.Model);
                Console.WriteLine("Hafıza : " + kurs.Hafıza);
                Console.WriteLine("Fiyat : " + kurs.Fiyat);
                Console.WriteLine("\n");
            }

            Console.WriteLine("*****for*****");
            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine("Marka : " + Urunler[i].Marka);
                Console.WriteLine("Model : " + Urunler[i].Model);
                Console.WriteLine("Hafıza : " + Urunler[i].Hafıza);
                Console.WriteLine("Fiyat : " + Urunler[i].Fiyat);
                Console.WriteLine("\n");
            }

            Console.WriteLine("*****While*****");
            int x = 0;
            while (x<3)
            {
                Console.WriteLine("Marka : " + Urunler[x].Marka);
                Console.WriteLine("Model : " + Urunler[x].Model);
                Console.WriteLine("Hafıza : " + Urunler[x].Hafıza);
                Console.WriteLine("Fiyat : " + Urunler[x].Fiyat);
                Console.WriteLine("\n");
                x++;
            }
        }
    }
    class Urun
    {
        public string Marka{ get; set; }
        public string Model{ get; set; }
        public string Hafıza{ get; set; }
        public string Fiyat{ get; set; }
    }
}
