using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class  CategoryTUI:ITUI
    {
        private readonly Utility _utility;
        private string[] _categoriesPreDefined;
        private BasicTUI _basicTUI;
        private ConditionalStatementTUI _conditionalStatementTUI;
        private LoopTUI _loopTUI;
        private StringTUI _stringTUI;
        private RecursiveTUI _recursiveTUI;
        private LibraryFunctionsTUI _libraryFunctionsTUI;
        private RegularExpresionTUI _regularExpresionTUI;
        private LinqTUI _linqTUI;
        private MiscellaneousTUI _miscellaneousTUI;


        public CategoryTUI ()
        {
            _utility = new Utility();
            _categoriesPreDefined = new string[]
            {
                "Basics",
                "Conditional statements",
                "Loops",
                "Strings ",
                "Recursion ",
                "Library functions" ,
                "Regular expresions ",
                "Linq ",
                "Miscellaneous ",
            };
            _basicTUI = new BasicTUI ();
            _conditionalStatementTUI = new ConditionalStatementTUI ();
            _loopTUI = new LoopTUI ();
            _stringTUI = new StringTUI ();
            _recursiveTUI = new RecursiveTUI();
            _libraryFunctionsTUI = new LibraryFunctionsTUI();
            _regularExpresionTUI = new RegularExpresionTUI();
            _linqTUI = new LinqTUI ();
            _miscellaneousTUI = new MiscellaneousTUI ();
        }

        public void TUI ()
        {
            _utility.PrintTheTitleForACategory("Categories");
            Console.WriteLine("Your choses are");
            _utility.HelpText(_categoriesPreDefined);
            _utility.PrintQuitOption();
            Console.WriteLine("****Chose a Number ****");
            bool goon = true;

            // TUI MAIN CHOSE LOOP
            while (goon)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "":
                        _utility.PrintHelpOption();
                        break;
                    case "1":
                        _utility.PrintBackToCategoriesOption();
                        _basicTUI.TUI();
                        _utility.OnReturnToCategoies(_categoriesPreDefined);
                        break;
                    case "2":
                        _conditionalStatementTUI.TUI();
                        _utility.OnReturnToCategoies(_categoriesPreDefined);
                        break;
                    case "3":
                        _loopTUI.TUI();
                        _utility.OnReturnToCategoies(_categoriesPreDefined);
                        break;
                    case "4":
                        _stringTUI.TUI();
                        _utility.OnReturnToCategoies(_categoriesPreDefined);
                        break;
                    case "5":
                        _recursiveTUI.TUI();
                        _utility.PrintHelpOption();
                        break;
                    case "6":
                        _libraryFunctionsTUI.TUI();
                        _utility.PrintHelpOption();
                        break;
                    case "7":
                        _regularExpresionTUI.TUI();
                        _utility.PrintHelpOption();
                        break;
                    case "8":
                        _linqTUI.TUI();
                        _utility.PrintHelpOption();
                        break;
                    case "9":
                        _miscellaneousTUI.TUI();
                        _utility.PrintHelpOption();
                        break;
                    case "help":
                        _utility.PrintQuitOption();
                        _utility.HelpText(_categoriesPreDefined);
                        break;
                    case "q":
                        goon = false;
                        break;
                }
            }
        }
    }
}
