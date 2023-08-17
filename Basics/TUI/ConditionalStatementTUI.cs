using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class ConditionalStatementTUI : ITUI
    {
        private readonly string[] _predefinedExercises;
        private readonly Utility _utility;
        public ConditionalStatementTUI()
        {
            _predefinedExercises = new string[]
            {
                "Absolute value",
                "Divisible by 2 or 3",
                "If consists of uppercase letters",
                "If greater than third one",
                "if number is even",
                "if sorted ascending",
                "if has neighbour",
                "positive, negative or zero",
                "if year is leap",
                "if number contains 3"
            };

            _utility = new Utility();
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("Conditional Statements exercise");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();


            bool goon = true;
            ConditionalStatementsExercises exercises = new ConditionalStatementsExercises();
            while (goon)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("expected 6832 -> actual : " + exercises.AbsoluteValue(6832));
                        Console.WriteLine("expected 392 -> actual : " + exercises.AbsoluteValue(-392));
                        Console.WriteLine("expected 0 -> actual : " + exercises.AbsoluteValue(-0));
                        _utility.PrintHelpOption();
                        break;
                    case "2":
                        Console.WriteLine("expected 450 -> actual : " + exercises.DivisibleBy2or3(15, 30));
                        Console.WriteLine("expected 180 -> actual : " + exercises.DivisibleBy2or3(2, 90));
                        Console.WriteLine("expected 19 -> actual : " + exercises.DivisibleBy2or3(7, 12));
                        _utility.PrintHelpOption();
                        break;
                    case "3":
                        Console.WriteLine("expected true -> actual : " + exercises.IfConsistsOfUppercaseLetters("DOG"));
                        Console.WriteLine("expected false -> actual : " + exercises.IfConsistsOfUppercaseLetters("xyz"));
                        Console.WriteLine("expected false -> actual : " + exercises.IfConsistsOfUppercaseLetters("L9#"));
                        _utility.PrintHelpOption();
                        break;
                    case "4":
                        Console.WriteLine("expected true -> actual : " + exercises.IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));
                        Console.WriteLine("expected false -> actual : " + exercises.IfGreaterThanThirdOne(new int[] { -5, -8, 50 }));
                        _utility.PrintHelpOption();
                        break;
                    case "5":
                        Console.WriteLine("expected false -> actual : " + exercises.IfNumberIsEven(721));
                        Console.WriteLine("expected true -> actual : " + exercises.IfNumberIsEven(1248));
                        _utility.PrintHelpOption();
                        break;
                    case "6":
                        Console.WriteLine("expected true -> actual : " + exercises.ifSortedAscending(new int[] { 3, 7, 10 }));
                        Console.WriteLine("expected false -> actual : " + exercises.ifSortedAscending(new int[] { 74, 62, 99 }));
                        Console.WriteLine("expected false -> actual : " + exercises.ifSortedAscending(new int[] { 74, 62, 99, 55 }));
                        Console.WriteLine("expected true -> actual : " + exercises.ifSortedAscending(new int[] { 2, 8, 14, 66, 312 }));
                        _utility.PrintHelpOption();
                        break;
                    case "7":
                        Console.WriteLine("expected true -> actual : " + exercises.IfHasNeighbour("XYZ"));
                        Console.WriteLine("expected false -> actual : " + exercises.IfHasNeighbour("GWK"));
                        _utility.PrintHelpOption();
                        break;
                    case "8":
                        Console.WriteLine("expected positive -> actual :" + exercises.PositiveNegativeOrZero(5.24));
                        Console.WriteLine("expected zero -> actual :" + exercises.PositiveNegativeOrZero(0.0));
                        Console.WriteLine("expected negative -> actual :" + exercises.PositiveNegativeOrZero(-994.53));
                        _utility.PrintHelpOption();
                        break;
                    case "9":
                        Console.WriteLine("expected true -> actual :" + exercises.IfYearIsLeap(2016));
                        Console.WriteLine("expected false -> actual :" + exercises.IfYearIsLeap(2018));
                        Console.WriteLine("expected false -> actual :" + exercises.IfYearIsLeap(1900));
                        Console.WriteLine("expected true -> actual :" + exercises.IfYearIsLeap(2000));
                        Console.WriteLine("expected true -> actual :" + exercises.IfYearIsLeap(2012));
                        _utility.PrintHelpOption();
                        break;
                    case "10":
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201432));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201403));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201413));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201423));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201443));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201453));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201463));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201473));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201483));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7201493));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(7231493));
                        Console.WriteLine("expected false->actual :" + exercises.IfNumberContains3(-7231493));
                        Console.WriteLine("expected false->actual :" + exercises.IfNumberContains3(19));
                        Console.WriteLine("expected false->actual :" + exercises.IfNumberContains3(87501));
                        Console.WriteLine("expected true->actual :" + exercises.IfNumberContains3(5384562));
                        _utility.PrintHelpOption();
                        break;
                    case "0":
                        goon = false;
                        break;

                }
            }

        }
    }
}
