using System;
using System.Linq;

namespace Homework_5_Source_Task_2
{
    class Program
    {
        /// <summary>
        /// Метод принимающий текст (строку) и возвращающий слово с минимальным количеством букв
        /// </summary>
        /// <param name="Source">Исходный текст (строка)</param>
        /// <returns></returns>
        static string MinWord(string Source)
        {
            string[] words = Source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words = words.OrderBy(x => x.Length).ToArray();
            string minLengthWord = words.First();
            return minLengthWord;
        }

        /// <summary>
        /// Метод, принимающий текст и возвращающий слово (слова) с максимальным количеством букв. 
        /// </summary>
        /// <param name="Source">Исходный текст (строка)</param>
        /// <returns></returns>
        static string[] MaxWord(string Source)
        {
            string[] words = Source.Split(new char[] { ',', '.', ' ', '!', '?', ';', '-', '/', '*' }, StringSplitOptions.RemoveEmptyEntries);
            words = words.OrderBy(x => x.Length).ToArray();

            string[] wordsMax = new string[words.Length];
            int j = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[words.Length - 1].Length == words[i].Length)
                {
                    wordsMax[j] = words[i];
                    j++;
                } else
                {
                    break;
                }
            }

            return wordsMax;
        }

        /// <summary>
        /// Метод вывода строк массива
        /// </summary>
        /// <param name="Source">Исходный массив</param>
        static void DisplayArray(string[] Source)
        {
            for (int i = 0; i < Source.Length; i++)
            {
                Console.Write(Source[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Тема 5. Домашнее задание.\n");
            // Задание 2.1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 2.1. Создать метод, принимающий текст и возвращающий минимальное слово.\n");
            Console.ResetColor();
            Console.WriteLine("Введите предложение\n");
            string str = Console.ReadLine();
            Console.WriteLine("Самое короткое слово: " + MinWord(str) + "\n");
            // Задание 2.2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 2.2. Создать метод, принимающий текст и возвращающий слово (слова) с максимальным количеством букв.\n");
            Console.ResetColor();
            Console.WriteLine("Введите предложение\n");
            str = Console.ReadLine();
            Console.WriteLine("Самые длииные слова: ");
            DisplayArray(MaxWord(str));

            Console.ReadKey();
        }
    }
}
