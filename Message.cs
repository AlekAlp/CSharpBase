using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    static class Message
    {
        public static void VaultLetterMessage(string[] message, int vault)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if(message[i].Length <= vault)
                    Console.WriteLine(message[i]);
            }
        }

        public static void DeleteWordLastLetter(string[] message, char letter)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i][message[i].Length-1] != letter)
                    Console.WriteLine(message[i]);
            }
        }

        public static void LenghtWordLetter(string[] message)
        {
            int vault = 0;
            int lenghtIndex = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Length > vault)
                {
                    vault = message[i].Length;
                    lenghtIndex = i;
                }
            }
            Console.WriteLine(message[lenghtIndex]);
        }

        public static StringBuilder LenghtWords(string[] message, int vault = 0)
        {
            StringBuilder lenghtStringWords = new StringBuilder("");
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Length > vault)
                {
                    lenghtStringWords.Append(message[i]);
                    lenghtStringWords.Append(" ");
                }
            }            
            return lenghtStringWords;
        }

        public static bool Anagram(string firstMessage, string secondMessage)
        {
            int check = 0;
            if (firstMessage.Length == secondMessage.Length)
                for (int i = 0; i < firstMessage.Length; i++)
                {
                    for (int j = 0; j < secondMessage.Length; j++)
                    {
                        if (firstMessage[i] == secondMessage[j])
                        {
                            check++;
                            break;
                        }
                    }
                }
            if (firstMessage.Length == check)
                return true;

            return false;
        }
    }
}