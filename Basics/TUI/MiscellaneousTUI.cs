using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CSharpExercisesFirstTry.Exercise;

namespace CSharpExercisesFirstTry.TUI
{
    internal class MiscellaneousTUI: ITUI
    {
        private Utility _utility;
        private string[] _predefinedExercises;

        public MiscellaneousTUI()
        {
            _utility = new Utility();
            _predefinedExercises = new string[]
            {
                "How many days",
            };
        }

        public void TUI()
        {
            _utility.PrintTheTitleForACategory("Miscellanous Exercises");
            _utility.HelpText(_predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();

            MiscellaneousExercises exercises = new MiscellaneousExercises();
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
                        _utility.PrintExerciseTextNonEnumerables("6405 ", exercises.HowManyDays(new DateTime(2006 , 1, 31), new DateTime(2023,8,14)));
                        break;
                    default:
                        Console.WriteLine("pick either 1 for exercises or 0 for going back to categories");
                        break;
                }
            }
        }
    }
}
