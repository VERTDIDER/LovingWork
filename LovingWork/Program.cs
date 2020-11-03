using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LovingWork
{
    class LovingWorkWithDate
    {
        public string toDateWithTime(DateTime d) => d.ToString("g");
        public string toDate(DateTime d) => d.ToString("d");
        public DateTime toLogicDate(string s)
        {
            var provider = new CultureInfo("ru-RU");
            try
            {
                var dt = DateTime.ParseExact(s, "g", provider);
                return dt;
            }
            catch (FormatException)
            {
                Console.WriteLine("Unacceptable data format");
                return DateTime.Now;
            }
        }
    }

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
            return $"Count of words - {count_of_words}, count of words including letter- {count_of_words_including_letter}, count of letter - {count_of_letter}";
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DateTime withtime = DateTime.Now;
            //string date_str = "15.06.2015";
            //LovingWorkWithDate love = new LovingWorkWithDate();
            //Console.WriteLine("g: " + love.toDateWithTime(withtime));
            //Console.WriteLine("d: " + love.toDate(withtime));
            //Console.WriteLine(love.toLogicDate(date_str));
            string str = "rama mau djhed aejkncje weuf";
            LovingWorkWithStrings love = new LovingWorkWithStrings();
            Console.WriteLine(love.GetStringInfo(str));
        }
    }
}
