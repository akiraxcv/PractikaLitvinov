using System;

namespace _1day1task
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = 230; // диапазон поиска простых чисел
                bool[] primes = new bool[n + 1];

                for (int i = 2; i <= n; i++)
                {
                    primes[i] = true;
                }

                for (int i = 2; i * i <= n; i++)
                {
                    if (primes[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            primes[j] = false;
                        }
                    }
                }

                Console.WriteLine("Простые числа от 1 до {0}: ", n);
                for (int i = 2; i <= n; i++)
                {
                    if (primes[i])
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
    }
