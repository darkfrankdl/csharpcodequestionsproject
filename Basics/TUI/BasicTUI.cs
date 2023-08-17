using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class BasicTUI : ITUI
    {
        private readonly string[] _predefinedExercises;
        private readonly Utility _utility;
        
        public BasicTUI()
        {
            _predefinedExercises = new string[]
            {
            "Add Two Numbers",
            "celsius to fehenheit ",
            "EmentaryOperations",
            "IsTheResultTheSame",
            "Modulo operations",
            "The Cube Of",
            "Swap two numbers",
            };

            _utility = new Utility();
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("Basics");
            _utility.HelpText(_predefinedExercises);

            bool goon = true;
            BasicsExercises basic = new BasicsExercises();
            while (goon)
            {
                
                Console.WriteLine("****Chose a number ****");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "":
                        Console.WriteLine("for help type \"help\"");
                        break;
                    case "1":
                        double num = basic.AddTwoNumbersThenMultiplyByOneNumber(2, 4, 5);
                        Console.WriteLine("expeted 30 -> actual = " + num);
                        break;
                    case "2":
                        Console.WriteLine("expect 32F -> actual " + basic.CelsiusToFehrenheit(0));
                        break;
                    case "3":
                        Console.WriteLine("Expected output is 11 -5 24 0,375 -> actual : ");
                        basic.ElementaryOperations(3, 8);
                        break;
                    case "4":
                        Console.WriteLine("Expected true -> " + basic.IsResultTheSame("2+2", "2*2"));
                        Console.WriteLine("Expected true -> " + basic.IsResultTheSame("-16+5", "1--12"));
                        break;
                    case "5":
                        basic.ModuloOperations(8, 5, 2);
                        basic.ModuloOperations(8, 0, 2);
                        basic.ModuloOperations(8, 5, 0);
                        break;
                    case "6":
                        Console.WriteLine("expected 8 -> actual : " + basic.TheCubeOf(2));
                        Console.WriteLine("expected -166,375 -> actual : " + basic.TheCubeOf(-5.5));
                        break;
                    case "7":
                        Console.WriteLine("Expected 3,2  -> after swap: " + basic.SwapTwoNumber(2, 3));
                        break;
                    case "help":
                        _utility.PrintBackToCategoriesOption();
                        _utility.HelpText(_predefinedExercises);
                        break;
                    case "0":
                        goon = false;
                        break;
                }
            }
        }
    }
}
