using System;

namespace _1day2task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку текста: ");
            string input = Console.ReadLine();

            // Разделяем строку на массив слов
            string[] words = input.Split(new char[] { ' ', ',', '.', ':', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слова, начинающиеся на букву 'а':");
            foreach (string word in words)
                if (word.StartsWith("а", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
