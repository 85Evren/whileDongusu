using System;

namespace fordongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For örneği");

            Console.WriteLine("Kaç adet sayı girdiniz. ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            
            for (int i = 0 ; i < n; i++)
            {
                Console.WriteLine($"{i + 1 }.Sayıyı girdiniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                              
                toplam += sayi;

            }

            Console.WriteLine($"Girilen sayıların toplamı: {toplam} 'dır.");
            Console.ReadKey();
        }
    }
}
