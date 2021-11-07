using System;

namespace EnbuyukHesaplama
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet çift sayı gireceksiniz.");
            int vize1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç adet çift sayı gireceksiniz.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç adet çift sayı gireceksiniz.");
            int n = Convert.ToInt32(Console.ReadLine());





            int toplam = 0;
            int enb = -1;
            int enk = -1;
            int ort = -1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {i + 1}.Sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi % 2 != 0)
                {
                    --i;// girilen sayının çift sayı olmaması durumunda sayı kabul edilmez. çift sayı giriş yapılırsa ilerler. 
                    Console.WriteLine($"{sayi} tek sayıdır. Çift sayı girişi yapınız.");
                    continue;
                }

                if (sayi > enb)
                { 
                    enb = sayi; 
                }
                
                toplam += sayi;
            }
            
            Console.WriteLine($"Sayı toplamı {toplam}");
            Console.WriteLine($"Enbüyük sayı {enb}");
            Console.WriteLine($"Enküyük sayı {enk}");
            Console.WriteLine($"ortalama sayı {ort}");
            Console.ReadLine();

        }
        
    }
}
