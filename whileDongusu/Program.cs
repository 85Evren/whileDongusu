﻿using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpım Tablosu ......");

            Console.WriteLine("Kaça kadar çarpmak istiyorsunuz. Max. 10......");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 1 && n < 10)
            {
                int i = 1;
                int j = 1;
                while (i <= n)
                {

                    while ( j <= 10)
                    {
                        int sonuc = i * j;
                        Console.WriteLine($"{i} * {j} = {sonuc}");
                        j++;

                    }

                    j = 1;
                    Console.WriteLine("************************************************");
                    i++;
                }
                
            }
            else
            {
                Console.WriteLine("Değer dışındadır. ");
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
