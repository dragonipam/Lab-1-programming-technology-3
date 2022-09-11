using System;

/*1.В тексте удалить каждое слово с четным числом символов, 
 * 2.продублировать каждое слово с нечетным числом символов, 
 * 3.заменив все вхождения букв ‘d’ на букву ‘t’ .*/

namespace Z3
{
    public class Logic
    {
        public static string Compare(string[] initialString)
        {
            string[] finiteString = new string[initialString.Length * 2];
            int j = 0;
            for (int i = 0; i < initialString.Length; i++)
            {
                if (initialString[i].Length % 2 == 0)
                {
                    finiteString[j] = initialString[i].Replace('d', 't');
                    finiteString[j + 1] = initialString[i].Replace('d', 't');
                    j += 2;
                }
            }
            String outMessage = "";
            for (int i = 0; i < initialString.Length * 2; i++)
            {
                outMessage += (finiteString[i] + " ");
            }
            return outMessage;
        } 
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string[] initialString = Console.ReadLine().Split(' ');
            Console.Write(Logic.Compare(initialString));
        }
    }
}
