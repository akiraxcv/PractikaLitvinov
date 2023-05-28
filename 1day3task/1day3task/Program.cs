using System;

namespace _1day3task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine($"Первые {n} чисел Фибоначчи:");
            Console.Write($"{a}, {b}");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($", {c}");
                a = b;
                b = c;
            }

            Console.ReadKey();
        }
    }
}
