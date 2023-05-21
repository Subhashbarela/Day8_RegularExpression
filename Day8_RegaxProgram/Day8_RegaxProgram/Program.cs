using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_RegaxProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("1:Charctor Checking \n2: Sequence Of Char Checking \n3: Fetch HTML tag" +
                "\n4: Count number of occurence of pattern in string\n5: File Type Extention");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
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
                        break;
                    }
                case 2:
                    {
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
                        break;
                    }
                case 3:
                    {                        
                        string str = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
                         pattern.Match_HTML_Tag(str);
                       
                        break;
                    }
                case 4:
                    {                        
                        string str =@"foxes are omnivorous mammals belonging to several generaof the family Canidae fox.";
                        int count= pattern.Count_Frequency_Of_String(str);
                        Console.WriteLine($"There are {count} matches");

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter the string : ");
                        string str = Console.ReadLine();
                        bool isValid = pattern.Image_File_Extention(str);
                        if (isValid)
                        {
                            Console.WriteLine("File Type extention is valid...!");
                        }
                        else
                        {
                            Console.WriteLine("File Type extention is not valid...!");
                        }
                        break;
                    }
                       
                        default:
                    {
                        Console.WriteLine("Please insert the valid number");
                        break;
                    }

            }

            Console.ReadLine();
        }
    }
}
