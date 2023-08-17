using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpExercisesFirstTry.Exercise;

namespace CSharpExercisesFirstTry.TUI
{
    internal class LibraryFunctionsTUI:ITUI
    {
        private Utility _utility;
        private string[] _predefinedExercises;

        public LibraryFunctionsTUI()
        {
            _utility = new Utility();
            _predefinedExercises = new string[]
            {
                "Negative or Positive",
                "Replace x with y",
                "To lower or to upper",
                "Greater number",
                "If starts with lower case",
            };
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("Library Function Exercises");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintHelpOption();
            _utility.PrintBackToCategoriesOption();
            LibraryFunctionsExercises exercises = new LibraryFunctionsExercises();

            bool goon = true;
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
                            Console.WriteLine("Expected output is 4 -> actual output is : " + exercises.NegativeOrPositive(-2));
                            Console.WriteLine("Expected output is 2,5 -> actual output is : " + exercises.NegativeOrPositive(6.25));
                            break;
                        case "2":
                            Console.WriteLine("Expected output is xellow -> actual output is : " + exercises.ReplaceXWithY("yellow"));
                            Console.WriteLine("Expected output is mushroom -> actual output is : " + exercises.ReplaceXWithY("mushroom"));
                            break;
                        case "3":
                            Console.WriteLine("Expected output is THIS is IT -> actual output is : " + exercises.ToLowerOrToUpper("this is it"));
                            break;
                        case "4":
                            Console.WriteLine("Expected output is 3 -> actual output is : " + exercises.GreaterNumber(2.3,3));
                            Console.WriteLine("Expected output is 0 -> actual output is : " + exercises.GreaterNumber(0,-5));
                            break;
                        case "5":
                            Console.WriteLine("Expected output is Alfa Beta amma -> actual output is : " + exercises.IfStartsWithLowerCase("Alfa Beta gamma"));
                            break;
                        default:
                            Console.WriteLine("Pick a number between 1-5 or 0 for going back");
                            break;

                    }
                }
            }
        }
    }
}
