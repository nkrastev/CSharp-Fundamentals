using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();            

            Regex regexCapitalLetters = new Regex(@"([#$%*&])([A-Z]+)\1");
            MatchCollection capLetters = regexCapitalLetters.Matches(input[0]);

            //foreach (Match item in capLetters)
            //{
            //    Console.WriteLine(item.Groups[2].Value);
            //}

            Regex regexWordsLenght = new Regex(@"[0-9]{2}:[0-9]{2}");
            MatchCollection wordsLenght = regexWordsLenght.Matches(input[1]);

            //foreach (Match item in wordsLenght)
            //{
            //    Console.WriteLine(item.Value);
            //}

            List<string> wordsPart3 = input[2].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //foreach (var item in wordsPart3)
            //{
            //    Console.WriteLine(item);
            //}

            // check if each item in the list wordsPart3 meet the conditions
        }

    }
}
