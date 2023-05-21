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
            string answer = "";
            do
            {
                Console.WriteLine("1:Charctor Checking \n2: Sequence Of Char Checking \n3: Fetch HTML tag" +
                    "\n4: Count number of occurence of pattern in string\n5: File Type Extention\n6: URL Address Formater");
                Console.WriteLine("Please insert your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                             string regax = "^ab{2,3}";
                            Console.WriteLine("Enter the string : ");
                            string str = Console.ReadLine();
                            bool isValid = pattern.CharMatch(str, regax);
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
                             string regax = "^[a-z]+_[a-z]+$";
                            Console.WriteLine("Enter the string : ");
                            string str = Console.ReadLine();
                            bool isValid = pattern.CharMatch(str, regax);
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
                            string regax =  @"<.*?>";
                            string str = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
                            pattern.Match_HTML_Tag(str,regax);

                            break;
                        }
                    case 4:
                        {      
                            string regax = @"fox(es)?";
                            string str = @"foxes are omnivorous mammals belonging to several generaof the family Canidae fox.";
                            int count = pattern.Count_Frequency_Of_String(str, regax);
                            Console.WriteLine($"There are {count} matches");

                            break;
                        }
                    case 5:
                        {
                            string regax = @"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)";
                            Console.WriteLine("Enter the File name to match a pattern : ");
                            string str = Console.ReadLine();
                            bool isValid = pattern.Image_File_Extention(str, regax);
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
                    case 6:
                        {
                             string regax = @"((http|https)://)(www.)?[a-zA-Z0-9@:%._\+~#?&//=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%._\+~#?&//=]*)";
                            Console.WriteLine("Enter the Website Address : ");
                            string str = Console.ReadLine();
                            bool isValid = pattern.Image_File_Extention(str, regax);
                            if (isValid)
                            {
                                Console.WriteLine("URL Format  is valid...!");
                            }
                            else
                            {
                                Console.WriteLine("URL Format is not valid...!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert the valid number");
                            break;
                        }
                }
                Console.WriteLine("Do you want to contienue ..?");
                answer=Console.ReadLine();
            } while (answer == "yes" || answer == "y");

            Console.ReadLine();
        }
    }
}
