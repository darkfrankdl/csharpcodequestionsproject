using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class StringTUI : ITUI
    {
        private readonly Utility _utility;
        private readonly string[] _predefinedExercises;

        public StringTUI ()
        {
            _utility = new Utility ();
            _predefinedExercises = new string[]
            {
                "Check Brackets sequence",
                "Add seperator",
                "Is palindrome",
                "Length of string",
                "String in reverse order",
                "Sum digits in string",
                "Make uppercase",
                "Mix two strings",
                "Number of words",
                "Revert words order",
                "how many occurrences",
                "sort characters descending",
                "Compress string"
            };
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("String exercises");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();
            StringExercises exercises = new StringExercises();

            bool continueStringExercises = true;


            while (continueStringExercises)
            {
                string userInput = Console.ReadLine();

                if (userInput != null)
                {
                    switch (userInput)
                    {
                        case "0":
                            continueStringExercises = false;
                            break;
                        case "1":
                            Console.WriteLine("expected true actual -> : " + exercises.CheckBracketsSequence("((()))"));
                            Console.WriteLine("expected false actual -> : " + exercises.CheckBracketsSequence("()(())("));
                            Console.WriteLine("expected false actual -> : " + exercises.CheckBracketsSequence(")"));
                            _utility.PrintHelpOption();
                            break;
                        case "2":
                            Console.WriteLine("expected A^B^C^D actual -> : " + exercises.AddSeperator("ABCD", "^"));
                            Console.WriteLine("expected c-h-o-c-o-l-a-t-e actual -> : " + exercises.AddSeperator("chocolate", "-"));
                            _utility.PrintHelpOption();
                            break;
                        case "3":
                            Console.WriteLine("expected output is true -> actual output is: " + exercises.IsPalindrome("eye"));
                            Console.WriteLine("expected output is false -> actual output is: " + exercises.IsPalindrome("home"));
                            _utility.PrintHelpOption();
                            break;
                        case "4":
                            Console.WriteLine("Expected output is 8 -> actual output is : " + exercises.LengthOfAString("computer"));
                            Console.WriteLine("Expected output is 9 -> actual output is : " + exercises.LengthOfAString("ice cream"));
                            _utility.PrintHelpOption();
                            break;
                        case "5":
                            Console.WriteLine("Expected output is ytrewq -> actual output is : " + exercises.StringInReverseOrder("qwerty"));
                            Console.WriteLine("Expected output is rk 39eo -> actual output is : " + exercises.StringInReverseOrder("oe93 kr"));
                            _utility.PrintHelpOption();
                            break;
                        case "6":
                            Console.WriteLine("Expected output is 6 -> actual output is : " + exercises.SumDigitsInString("1q2w3e"));
                            Console.WriteLine("Expected output is 9 -> actual output is : " + exercises.SumDigitsInString("L0r3m.1p5um"));
                            Console.WriteLine("Expected output is 0 -> actual output is : " + exercises.SumDigitsInString(""));
                            _utility.PrintHelpOption();
                            break;
                        case "7":
                            Console.WriteLine("Expected output is MoDeM -> actual output is : " + exercises.MakeUppercase("modem"));
                            Console.WriteLine("Expected output is BoOkWoRm -> actual output is : " + exercises.MakeUppercase("BookWorm"));
                            Console.WriteLine("Expected output is AlIqUaM DoLoR NiSl?  -> actual output is : " + exercises.MakeUppercase("Aliquam dolor nisl?"));
                            _utility.PrintHelpOption();
                            break;
                        case "8":
                            Console.WriteLine("Expected output is \"aBaBaB\" actual value is -> " + exercises.MixTwoStrings("aaa", "BBB"));
                            Console.WriteLine("Expected output is \"g1o1o1d one\" actual value is -> " + exercises.MixTwoStrings("good one", "111"));
                            _utility.PrintHelpOption();
                            break;
                        case "9":
                            Console.WriteLine("Expected output is 4 -> actual output is : " + exercises.NumberOfWords("This is sample sentence"));
                            Console.WriteLine("Expected output is 1 -> actual output is : " + exercises.NumberOfWords("OK"));
                            _utility.PrintHelpOption();
                            break;
                        case "10":
                            Console.WriteLine("Expected \"Doe John.\" -> actual output is : " + exercises.RevertWordsOrder("John Doe."));
                            Console.WriteLine("Expected \"haj computer din dig med hej.\" -> actual output is : " + exercises.RevertWordsOrder("hej med dig din computer haj."));
                            _utility.PrintHelpOption();
                            break;
                        case "11":
                            Console.WriteLine("Expected output is 1 -> actural output is : " + exercises.HowManyOccurrences("do it now", "do"));

                            _utility.PrintHelpOption();
                            break;
                        case "12":
                            Console.WriteLine("Expected output is \"tpoooonmieaa\" -> actural output is : ");
                            exercises.SortCharactersDescending("onomatopoeia");                            
                            Console.WriteLine("Expected output is \"wsoojhff42\" -> actural output is : ");
                            exercises.SortCharactersDescending("fohjwf42os");
                            _utility.PrintHelpOption();
                            break;
                        case "13":
                            Console.WriteLine("expected output is k4t3r10 actual output is : " + exercises.CompressString("kkkktttrrrrrrrrrr"));
                            Console.WriteLine("expected output is p153p371w3 actual output is : " + exercises.CompressString("p555ppp7www"));

                            _utility.PrintHelpOption();
                            break;
                        case "help":
                            _utility.HelpText(_predefinedExercises);
                            break;
                        default:
                            Console.WriteLine("You can only chose a number between 1-13 to run the exercises");
                            break;

                    }
                }
            }

        }
    }
}
