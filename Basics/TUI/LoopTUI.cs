using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class LoopTUI : ITUI
    {
        private readonly Utility _utility;
        private readonly string[] _predefinedExercises;

        public LoopTUI ()
        {
            _utility = new Utility();
            _predefinedExercises = new string[]
            {
                "Multiplication Table",
                "Fractions Sum",
                "Sort array ascending",
                "The biggest number",
                "Two 7s next to each other",
                "Three increasing adjacent",
                "Return even numbers",
                "Sieve of Eratosthenes",
                "Draw hourglass",
                "Draw parallelogram",
                "Draw Christmas tree",
                "Extract string",
                "Full sequence of letters",
                "Longest strictly increasing sequence",
                "Bits to number",
                "Digits sum",
                "Sum and average",
                "Sum double only",
                "Draw triangle",
                "To the power of",
                "Letters balance",
                "Replace two words",
                "Digital root",
            };
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("Loop exercise");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();


            bool goon = true;
            LoopsExercises exercises = new LoopsExercises();
            while (goon)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Expects the following");
                        Console.WriteLine(@"
                            1  2  3  4  5  6  7  8  9 10

                            2  4  6  8 10 12 14 16 18 20

                            3  6  9 12 15 18 21 24 27 30

                            4  8 12 16 20 24 28 32 36 40

                            5 10 15 20 25 30 35 40 45 50

                            6 12 18 24 30 36 42 48 54 60

                            7 14 21 28 35 42 49 56 63 70

                            8 16 24 32 40 48 56 64 72 80

                            9 18 27 36 45 54 63 72 81 90

                            10 20 30 40 50 60 70 80 90 100");
                        exercises.MultiplicationTable();
                        _utility.PrintHelpOption();
                        break;
                    case "2":
                        _utility.PrintExerciseTextNonEnumerables("1.36111", exercises.FractionsSum(3));
                        _utility.PrintExerciseTextNonEnumerables("1.4616111", exercises.FractionsSum(5));
                        _utility.PrintHelpOption();
                        break;
                    case "3":
                        Console.WriteLine("Expects the following");
                        Console.WriteLine(@"1, 2, 5, 7, 8, 9");
                        exercises.SortArrayAscending(new int[] { 9, 5, 7, 2, 1, 8 });
                        _utility.PrintHelpOption();
                        break;
                    case "4":
                        _utility.PrintExerciseTextNonEnumerables("300", exercises.TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 300 }));
                        _utility.PrintExerciseTextNonEnumerables("-2", exercises.TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }));
                        _utility.PrintHelpOption();
                        break;
                    case "5":
                        _utility.PrintExerciseTextNonEnumerables("1", exercises.Two7sNextToEachOther(new double[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
                        _utility.PrintHelpOption();
                        break;
                    case "6":
                        _utility.PrintExerciseTextNonEnumerables("True", exercises.ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
                        _utility.PrintExerciseTextNonEnumerables("False", exercises.ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
                        _utility.PrintHelpOption();
                        break;
                    case "7":
                        _utility.PrintExerciseTextNonEnumerables("2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98", exercises.ReturnEvenNumbers());
                        _utility.PrintHelpOption();
                        break;
                    case "8":
                        Console.WriteLine("Expects -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 : Actual output is ->>"); 
                        exercises.SieveOfEratosthenes(30);
                        _utility.PrintHelpOption();
                        break;
                    case "9":
                        Console.WriteLine("Expect output :");
                        Console.WriteLine(@"
                            ***********

                             *********

                              *******

                               *****

                                ***

                                 *

                                ***

                               *****

                              *******

                             *********

                            ***********");
                        exercises.DrawHourGlass();
                        _utility.PrintHelpOption();
                        break;
                    case "10":
                        Console.WriteLine("Expect output :");
                        Console.WriteLine(@"     
                             ***************

                            ***************

                           ***************

                          ***************

                         ***************");
                        exercises.DrawParallelogram();
                        _utility.PrintHelpOption();
                        break;
                    case "11":
                        Console.WriteLine("Expect output :");
                        Console.WriteLine(@"     
                               *

                              ***

                             *****

                            *******

                               *

                              ***

                             *****

                            *******

                               *

                              ***

                             *****

                            *******");
                        exercises.DrawChristmasTreeOnlyLoops();
                        _utility.PrintHelpOption();
                        break;
                    case "12":
                        Console.WriteLine("expected output is : abc");
                        exercises.ExtractString("##abc##def");
                        Console.WriteLine("expected output is : empty string");
                        exercises.ExtractString("12####78");
                        Console.WriteLine("expected output is : Empty string");
                        exercises.ExtractString("gar##d#en");
                        Console.WriteLine("expected output is : --");
                        exercises.ExtractString("++##--##++");
                        _utility.PrintHelpOption();
                        break;
                    case "13":
                        _utility.PrintExerciseTextNonEnumerables("defghijklmnopqrs", exercises.FullSequenceOfLetters("ds"));
                        _utility.PrintExerciseTextNonEnumerables("opqr", exercises.FullSequenceOfLetters("or"));
                        _utility.PrintHelpOption();
                        break;
                    case "14":
                        _utility.PrintExerciseTextNonEnumerables("5", exercises.LongestStrictlyIncreasingSequence(new int[] { 0, 3, 4, 5, 6, 4, 9 }));
                        _utility.PrintExerciseTextNonEnumerables("0", exercises.LongestStrictlyIncreasingSequence(new int[] { 7, 7, 7, 7, 7 }));
                        _utility.PrintHelpOption();
                        break;
                    case "15":
                        _utility.PrintExerciseTextNonEnumerables("1", exercises.BitsToNumber("1"));
                        _utility.PrintExerciseTextNonEnumerables("34", exercises.BitsToNumber("100010"));
                        _utility.PrintHelpOption();
                        break;
                    case "16":
                        _utility.PrintExerciseTextNonEnumerables("16", exercises.DigitsSumArrayVersion(5434));
                        _utility.PrintExerciseTextNonEnumerables("28", exercises.DigitsSumArrayVersion(904861));
                        _utility.PrintHelpOption();
                        break;
                    case "17":
                        _utility.PrintExerciseTextNonEnumerables("Sum: 2156, Average: 38.5", exercises.SumAndAverage(11, 66));
                        _utility.PrintExerciseTextNonEnumerables("Sum: -55, Average: -5", exercises.SumAndAverage(-10,0));
                        _utility.PrintHelpOption();
                        break;
                    case "18":
                        _utility.PrintExerciseTextNonEnumerables("7.82", exercises.SumDoubleOnly(new object[] { "abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22 }));
                        _utility.PrintHelpOption();
                        break;
                    case "19":
                        Console.WriteLine("Expect output :");
                        Console.WriteLine(@"     
                                     *

                                    **

                                   ***

                                  ****

                                 *****

                                ******

                               *******

                              ********

                             *********

                            **********");
                        exercises.DrawTriangle(10);
                        _utility.PrintHelpOption();
                        break;
                    case "20":
                        _utility.PrintExerciseTextNonEnumerables("8", exercises.ToThePowerOf(-2,3));
                        _utility.PrintExerciseTextNonEnumerables("3125", exercises.ToThePowerOf(5,5));
                        _utility.PrintHelpOption();
                        break;
                    case "21":
                        _utility.PrintExerciseTextNonEnumerables("True", exercises.LettersBalance("fgvgvf"));
                        _utility.PrintExerciseTextNonEnumerables("false", exercises.LettersBalance("lampsmpser"));
                        _utility.PrintHelpOption();
                        break;
                    case "22":
                        _utility.PrintExerciseTextNonEnumerables("xyz_abc", exercises.ReplaceTwoWords("abc_xyz", '_'));
                        _utility.PrintExerciseTextNonEnumerables("master.trolling", exercises.ReplaceTwoWords("trolling.master", '.'));
                        _utility.PrintHelpOption();
                        break;
                    case "23":
                        _utility.PrintExerciseTextNonEnumerables("2", exercises.DigitalRoot(83));
                        _utility.PrintExerciseTextNonEnumerables("8", exercises.DigitalRoot(40002938));
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
