using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace LovingWork
{
    class LovingWorkWithStrings
    {
        public string GetStringInfo(string s)
        {
            Console.Write("letter - ");
            char letter = Convert.ToChar(Console.Read());
            Console.WriteLine();
            //
            // в реальности нужно использовать try catch OverFlowException при console read и конверте
            //
            int count_of_letter = 0;
            foreach (char c in s)
            {
                count_of_letter = (c == letter) ? count_of_letter + 1 : count_of_letter;
            }

            string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int count_of_words = words.Length;

            int count_of_words_including_letter = 0;
            foreach (string word in words)
            {
                if (word.Contains(letter.ToString())) {
                    count_of_words_including_letter++;
                }
            }
            //
            //StringBuilder использовать не нужно, т.к. операция со строкой проходит один раз
            //
            return $"count of words - {count_of_words}, count of words including letter - {count_of_words_including_letter}, count of letter - {count_of_letter}";
        }

        //в чем разница List<int> и int[]?
        public string GetStringFromList(List<int> numbers)
        {
            StringBuilder sb = new StringBuilder();
            //
            //StringBuilder нужен так как неопределенное колво итераций//
            //
            foreach (int number in numbers)
            {
                String temp = number.ToString();
                sb.Append($"{temp}, ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "rama mau djhed aejkncje  weuf";
            LovingWorkWithStrings love = new LovingWorkWithStrings();
            //Console.WriteLine(love.GetStringInfo(str));


            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine(love.GetStringFromList(numbers));
        }
    }
}
