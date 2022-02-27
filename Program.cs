using System;
using System.Text;

namespace Homework5
{
    class Program
    {
        public const int NUMBER = 4;
        public const char SYMBOL = 'd';
        static void Main(string[] args)
        {            
            Console.WriteLine(EnterLogin.CheckLogin(Console.ReadLine())); //Проверка логина

            string testString = "nifd nuijfd nuji nuijgkmf"; // строка для демонстрации результата работы методов            
            Console.WriteLine($"Вывод слов, с количеством букв менее {NUMBER}: ");
            Message.VaultLetterMessage(testString.Split(' '), NUMBER);
            Console.WriteLine();

            Console.WriteLine($"Вывод слов без символа {SYMBOL} в конце слова: ");
            Message.DeleteWordLastLetter(testString.Split(' '), SYMBOL);
            Console.WriteLine();

            Console.WriteLine("Вывод самого длинного слова: ");
            Message.LenghtWordLetter(testString.Split(' '));
            Console.WriteLine();

            Console.WriteLine($"Вывод слов, количество букв в которых более {NUMBER}");
            Console.WriteLine(Message.LenghtWords(testString.Split(' '), NUMBER));
            Console.WriteLine();

            string firstWord = "qwertyasdfgh";
            string secondWord = "asdfghqwerty";
            Console.Write($"Являются ли слова {firstWord} и {secondWord} анаграммами: ");
            Console.WriteLine(Message.Anagram(firstWord, secondWord));
            Console.ReadLine();
        }
    }
}
