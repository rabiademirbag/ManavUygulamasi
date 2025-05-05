using System;

namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavina Hos Geldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");

            Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
            string meyve = Console.ReadLine().ToLower();

            int fiyat = 0;

            /* if(meyve=="elma" || meyve == "çilek")
             {
                 fiyat = 2;
             }
             else if(meyve=="armut" || meyve=="muz")
             {
                 fiyat = 3;
             }
             else
             {
                 fiyat = 4;
             }
            */

            switch (meyve)
            {
                case "elma":
                case "çilek":
                    fiyat = 2; 
                    break;
                case "armut":
                case "muz":
                    fiyat = 3;
                    break;
                default:
                    fiyat = 4;
                    break;
            }
            Console.WriteLine($"Seçtiginiz meyvenin fiyati: {fiyat} TL");

            // Her bir if koşulu sırayla kontrol edildiği için çok fazla seçenek olduğunda işlem maliyeti artabilir.
            // Bu durumda basit ve sabit değerlerin kontrolü için switch ifadesi daha okunabilir ve genellikle daha verimlidir.
        }
    }
}