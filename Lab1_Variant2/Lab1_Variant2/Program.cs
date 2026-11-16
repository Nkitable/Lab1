using System;

namespace Lab1_Variant2
{
    public class Program
    {
        public static int CalculateFullMinutes(int n)
        {
            int m = n / 60;
            return m;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть кількість секунд (N), що пройшли з початку доби:");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);

            int m = CalculateFullMinutes(n);

            Console.WriteLine($"Кількість повних хвилин: {m}");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
