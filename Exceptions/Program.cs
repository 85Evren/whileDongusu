using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girilen sayı{sayi}");
            }
            
            catch(FormatException ex)
            {
                Console.WriteLine($"Format hatası alınıyor.\n {ex}");


            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Format değer aralığı hatası alınıyor.\n {ex}");


            }
            Console.ReadLine();
        }
    }
}
