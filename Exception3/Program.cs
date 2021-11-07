using System;

namespace Exception3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            int toplam = 0;

            while (i < 5)
            {
                try
                {
                    Console.WriteLine($" Lütfen 0-255 arası {i + 1}.sayı girişi yapınız.");
                    byte sayi = Convert.ToByte(Console.ReadLine());
                    toplam += sayi;
                    i++;
                }
                catch
                {

                    Console.WriteLine("Hatalı bir işlem yaptınız.");
                }
            }

            Console.WriteLine($" Girilen sayı toplamı = {toplam}.");
            Console.ReadKey();
        }
    }
}
