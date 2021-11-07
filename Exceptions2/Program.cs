using System;
using System.Diagnostics;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer giriniz.");
            string str = "selam";
           
            bool durum = str is int;
            durum = str is string;
            durum = str is int;

            try
            {
                byte sayi = Convert.ToByte(Console.ReadLine());

            }

            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                // Print the line number
                Console.WriteLine($"An Error ({ex.Message}) occurred in line {line}");




                /*

                if ( ex is OverflowException)
                {
                    Console.WriteLine($"Bir değer aralığı hatası oluşmuştur.\n {ex}");

                }
                else if ( ex is FormatException)
                {

                    Console.WriteLine($"Bir format hatası oluşmuştur.\n {ex.Message}");

                }
                */
            }

            Console.ReadKey();

        }
    }
}
