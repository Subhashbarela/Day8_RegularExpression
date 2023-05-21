using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegaxProgram
{
    public class Pattern
    {
        
        public bool CharMatch(string message,string pattern)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
        public bool SequenceCharMatch(string message, string pattern)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
        public void Match_HTML_Tag(string message, string pattern)
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
        public int Count_Frequency_Of_String(string message, string pattern)
        {
            var n = Regex.Matches(message, pattern, RegexOptions.Compiled |RegexOptions.IgnoreCase).Count;
            return n;
        }
        public bool Image_File_Extention(string message, string pattern)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
        public bool URL_Address_Formate(string message, string pattern)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }

    }
}
