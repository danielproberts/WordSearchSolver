using System;
using System.Text.RegularExpressions;

namespace WordSearchSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindWord("test", "teaktestjadtestfakj"));
            Console.ReadKey();
        }

        public static int FindWord(string s, string m)
        {
            /*
            char[] splitWord = s.ToCharArray();
            char[] splitMatch = m.ToCharArray();
            */
            
            Regex rx = new Regex(@"(\W*((?i))" + s + @"((?-i))\W*)", RegexOptions.IgnoreCase);

            //Regex rx = new Regex(@"(test)", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(m);
            return matches.Count;
        }
    }
}
