using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LovingWork
{
    class LovingWorkWithStrings
    {
        public string GetStringInfo(string s)
        {
            string letter = "a";
            Regex regex = new Regex(letter);
            MatchCollection match = regex.Matches(s);
            int count_of_letter = match.Count;
            string[] words = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int count_of_words = words.Length;
            int count_of_words_including_letter = 0;
            foreach (string word in words)
            {
                if (word.Contains(letter)) {
                    count_of_words_including_letter++;
                }
            }
            return $"Количество слов - {count_of_words}, количество слов с данной буквой - {count_of_words_including_letter}, сколько раз буквы была найдена - {count_of_letter}";
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "rama mau djhed aejkncje weuf";
            LovingWorkWithStrings love = new LovingWorkWithStrings();
            Console.WriteLine(love.GetStringInfo(str));
        }
    }
}
