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
        public static string pattern = "^ab{2,3}";
        public bool CharMatch(string message)
        {
            bool match = Regex.IsMatch(message, pattern);
            return match;
        }
    }
}
