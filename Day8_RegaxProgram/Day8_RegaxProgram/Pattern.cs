using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegaxProgram
{
    public class Pattern
    {
        //public static string pattern = "^ab{2,3}";
       // public static string pattern = "^[a-z]+_[a-z]+$";
       // public static string pattern =  @"<.*?>";
        public static string pattern = @"fox(es)?";
        public bool CharMatch(string message)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
        public bool SequenceCharMatch(string message)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
        public void Match_HTML_Tag(string message)
        {
            var matches = Regex.Matches(message, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Match found:");
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
        public int Count_Frequency_Of_String(string message)
        {
            var n = Regex.Matches(message, pattern, RegexOptions.Compiled |RegexOptions.IgnoreCase).Count;
            return n;
        }

    }
}
