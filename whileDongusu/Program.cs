using System;

namespace whileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            do
            {
                Console.WriteLine($"Hello DoWhile! {sayac++}");
            } while (sayac < 10);
            
            while(false)
            {
                Console.WriteLine("Hello While!");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
