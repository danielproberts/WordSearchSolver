using System;
using System.Text.RegularExpressions;

namespace WordSearchSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindWord("test", "teaktest");
        }

        public static int FindWord(string s, string m)
        {
            char[] splitWord = s.ToCharArray();
            char[] splitMatch = m.ToCharArray();
            Regex rx = new Regex(@"(${matchWord})", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(s);
            return matches.Count;
        }
    }
}
