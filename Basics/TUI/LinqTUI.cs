using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpExercisesFirstTry.Exercise;

namespace CSharpExercisesFirstTry.TUI
{
    internal class LinqTUI:ITUI
    {
        private Utility _utility;
        private string[] _predefinedExercises;

        public LinqTUI()
        {
            _utility = new Utility();
            _predefinedExercises = new string[]
            {
                "Numbers from range",
                "Minimum length",
                "Select words",
                "Top 5 numbers",
                "Square greater than 20",
                "Replace substring",
                "Last word containing letter",
                "shuffle an array",
                "Decrypt number",
                "Most frequent character",
                "Unique values",
                "Uppercase only",
                "Arrays dot product",
                "Frequency of letters",
                "Days names",
                "Double letters",
                "Transpose an array",
            };
        }

        public void TUI ()
        {
            _utility.PrintTheTitleForACategory("Linq exercises");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();
            LinqExercises exercises = new LinqExercises();
            bool goon = true;
            while (goon)
            {
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "0":
                        goon = false;
                        break;
                    case "1":
                        _utility.PrintExerciseTextEnumerables("67,92", exercises.NumbersFromRange(new int[] { 67, 92, 153, 15 }));
                        break;
                    case "2":
                        _utility.PrintExerciseTextNonEnumerables("COMPUTER FERRY", exercises.MinimumLength(new string[] { "Computer", "ferry", "car", "bike" }));
                        break;
                    case "3":
                        _utility.PrintExerciseTextNonEnumerables("amsterdam", exercises.SelectWords(new string[] { "mum", "amsterdam", "bloom" }));
                        break;
                    case "4":
                        _utility.PrintExerciseTextEnumerables("86 78 54 23 21",exercises.Top5Numbers(new int[] { 78, -9, 0, 23, 54, 21, 7, 86 }));
                        break;
                    case "5":
                        exercises.SquareGreaterThan20(new double[] { 7, 2, 30 });
                        break;
                    case "6":
                        _utility.PrintExerciseTextNonEnumerables("l*rn, current\", d*l", exercises.ReplaceSubstring(new string[] { "learn", "current", "deal" }));
                        break;
                    case "7":
                        _utility.PrintExerciseTextNonEnumerables("plane", exercises.LastWordContainingLetter(new string[] { "plane", "ferry", "car", "bike" }));
                        break;
                    case "8":
                        _utility.PrintExerciseTextEnumerables("[0, -100, -17, 38, 8, -1, 24, -33,]",exercises.ShuffleAnArray(new int[] { 38, 24, 8, 0, -1, -17, -33, -100 }));
                        break;
                    case "9":
                        _utility.PrintExerciseTextNonEnumerables("1234567890", exercises.DecryptNumber("!@#$%&/()="));
                        _utility.PrintExerciseTextNonEnumerables("84937", exercises.DecryptNumber("($)#/"));
                        break;
                    case "10":
                        _utility.PrintExerciseTextNonEnumerables("most frequent character is n in n093nfv034nie9 ", exercises.MostFrequentCharacter("n093nfv034nie9"));
                        break;
                    case "11":
                        _utility.PrintExerciseTextNonEnumerables("klm , rst",exercises.UniqueValues(new string[] { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" }));
                        break;
                    case "12":
                        _utility.PrintExerciseTextNonEnumerables("DDD, CQRS", exercises.UppercaseOnly("DDD example CQRS Event Sourcing"));
                        break;
                    case "13":
                        _utility.PrintExerciseTextNonEnumerables("74", exercises.ArraysDotProduct(new int[] { 7, -9, 3, -5 }, new int[] { 9, 1, 0, -4 }));
                        break;
                    case "14":
                        exercises.FrequencyOfLetters("gamma");
                        break;
                    case "15":
                        _utility.PrintExerciseTextNonEnumerables("Sunday Monday Tuesday Wednesday Thursday Friday Saturday", exercises.DaysNames());
                        break;
                    case "16":
                        _utility.PrintExerciseTextNonEnumerables("AA AB AC -> ZX ZY ZZ", exercises.DoublesLetters());
                        break;
                    case "17":
                        _utility.PrintExerciseTextEnumerables("1234,1234,1234,1234",exercises.TransposeAnArray(new int[,] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 } , { 3, 3, 3, 3 }, { 4, 4, 4, 4 } }));
                        break;
                    default:
                        Console.WriteLine("Choose between 1-17 for exercises or 0 to go back ");
                        break;
                }
            }
        }
    }
}
