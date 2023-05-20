using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_RegaxProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            bool isValid = pattern.CharMatch(str);
            if (isValid)
            {
                Console.WriteLine("String is valid...!");
            }
            else
            {
                Console.WriteLine("String is not valid...!");
            }
            Console.ReadLine();
        }
    }
}
