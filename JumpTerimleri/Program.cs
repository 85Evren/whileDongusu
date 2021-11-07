using System;

namespace JumpTerimleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet çift sayı gireceksiniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {i + 1}.Sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                if(sayi % 2 != 0)
                {
                    --i;// girilen sayının çift sayı olmaması durumunda sayı kabul edilmez. çift sayı giriş yapılırsa ilerler. 
                    Console.WriteLine($"{sayi} tek sayıdır. Çift sayı girişi yapınız.");
                    continue;

                }
                else
                {
                    toplam += sayi;

                }

            }
            Console.WriteLine($"sayı toplamı {toplam}");
            Console.ReadLine();

        }
    }
}
