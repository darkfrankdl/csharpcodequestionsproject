using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class RecursiveTUI:ITUI
    {
        private readonly Utility _utility;
        private readonly string[] predefinedExercises;

        public RecursiveTUI()
        {
            _utility = new Utility();
            predefinedExercises = new string[]
            {
               "Digits multiplication",
               "Factorial",
               "Fibonacci number",
               "Numbers multiplication",
               "To the power of (recursion)",
               "String in reverse order (recursion)",
               "is palindrome (recursive)",
               "minimum element",
            };
        }

        public void TUI ()
        {
            _utility.PrintTheTitleForACategory("Recursive");
            _utility.HelpText(predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();


            Console.WriteLine("Choose a number");

            bool goon = true;
            RecursiveExercises exercises = new RecursiveExercises();
            while (goon)
            {
                string userInput = Console.ReadLine();

                if(userInput != null)
                {
                    switch(userInput)
                    {
                        case "0":
                            goon = false;
                            break;
                        case "1":
                            Console.WriteLine("Expected output is -> 120 _ actual output is :" + exercises.DigitsMultiplication(456));
                            Console.WriteLine("Expected output is -> 362880 _ actual output is :" + exercises.DigitsMultiplication(123456789));
                            break;
                        case "2":
                            Console.WriteLine("expected output is 24 -> actual output is : " + exercises.Factorial(4));
                            Console.WriteLine("expected output is 5040 -> actual output is : " + exercises.Factorial(7));
                            break;
                        case "3":
                            Console.WriteLine("expected output is 2 -> actual input is : " + exercises.FibonacciNumber(3));
                            Console.WriteLine("expected output is 13 -> actual input is : " + exercises.FibonacciNumber(7));
                            break;
                        case "4":
                            Console.WriteLine("expected output is 210 -> actual input is : " + exercises.NumbersMultiplication(5,7));
                            Console.WriteLine("expected output is 50 -> actual input is : " + exercises.NumbersMultiplication(50,50));
                            break;
                        case "5":
                            Console.WriteLine("expected output is 8 -> actual input is : " + exercises.ToThePowerOfRecursion(2,3));
                            Console.WriteLine("expected output is 25 -> actual input is : " + exercises.ToThePowerOfRecursion(5,2));
                            break;
                        case "6":
                            Console.WriteLine("Expected output is edcba -> actual output is : " + exercises.StringInReverseOrderRecursion("abcde"));
                            Console.WriteLine("Expected output is ue anru tu mutnemele ,tse sutcel deS -> actual output is : " + exercises.StringInReverseOrderRecursion("Sed lectus est, elementum ut urna eu"));
                            break;
                        case "7":
                            Console.WriteLine("Expected output is True -> actual output value is :" + exercises.IsPalinDromeRecursive("xx"));
                            Console.WriteLine("Expected output is False -> actual output value is :" + exercises.IsPalinDromeRecursive("pendrive"));
                            Console.WriteLine("Expected output is True -> actual output value is :" + exercises.IsPalinDromeRecursive("madam"));
                            break;
                        case "8":
                            Console.WriteLine("Expected output is 5 -> actual output is : " + exercises.MinimumElement(new int[] { 8, 5, 9 }, 3 ));
                            Console.WriteLine("Expected output is -9 -> actual output is : " + exercises.MinimumElement(new int[] { -2, -9, 2, -3, 1, 0 }, 6 ));
                            break;
                    }
                }
            }
        }

    }
}
