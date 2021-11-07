using System;

namespace forLoopOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpım Tablosu ......");

            Console.WriteLine("Kaça kadar çarpmak istiyorsunuz. Max. 10......");
            int n = Convert.ToInt32(Console.ReadLine());

           while(n > 1 && n < 10)
           {                     
   
                for(int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        int sonuc = i * j;
                        Console.WriteLine($"{i} * {j} = {sonuc}");

                    }
                    Console.WriteLine("************************************************");
                }
                n++;
            }
           
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
