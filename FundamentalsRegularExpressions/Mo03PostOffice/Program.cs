using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string capitalLetters = input[0];
            string secondPart = input[1];
            string wordsInput = input[2];

            Regex regexCapitalLetters = new Regex(@"([#$%*&])([A-Z]+)\1");
        }
    }
}
