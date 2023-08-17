using CSharpExercisesFirstTry.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.TUI
{
    internal class RegularExpresionTUI
    {
        private Utility _utility;
        private string[] predefinedExercises;

        public RegularExpresionTUI()
        {
            _utility = new Utility();
            predefinedExercises = new string[]
            {
                "Almost only letters",
                "Check phone number",
                "Decimal digit information",
                "Every word in the string",
                "Replace good with bad",
            };
        }

        public void TUI ()
        {
            _utility.PrintTheTitleForACategory("Regular expresion exercises");
            _utility.HelpText(predefinedExercises);
            _utility.PrintBackToCategoriesOption();
            _utility.PrintHelpOption();

            RegularExpresionExercises exercises = new RegularExpresionExercises();
            bool goon = true;

            while (goon)
            {
                string userinput = Console.ReadLine();
                if (userinput != null)
                {
                    switch(userinput)
                    {
                        case "0":
                            goon = false;
                            break;
                        case "1":
                            Console.WriteLine("Expected output is true -> actual output is : " + exercises.AlmostOnlyLetters("She is nice."));
                            Console.WriteLine("Expected output is False -> actual output is : " + exercises.AlmostOnlyLetters("true 222."));
                            break;
                        case "2":
                            Console.WriteLine("Expected ouput is true -> actual output is : " + exercises.CheckPhoneNumber("+35 392-022-194"));
                            Console.WriteLine("Expected ouput is false -> actual output is : " + exercises.CheckPhoneNumber("+958 28492-503"));
                            break;
                        case "3":
                            Console.WriteLine("Expected ouput is \"Digit 9 at position 8\" -> actual output is : " + exercises.DecimalDigitInformation("This is 9"));
                            break;
                        case "4":
                            Console.WriteLine("Expected ouput is True -> actual output is : " + exercises.EveryWordInTheString("Use Of Technology"));
                            Console.WriteLine("Expected ouput is False -> actual output is : " + exercises.EveryWordInTheString("Rocket science"));
                            Console.WriteLine("Expected ouput is False -> actual output is : " + exercises.EveryWordInTheString("As Fit As a Fiddle."));
                            break;
                        case "5":
                            Console.WriteLine("Expected bad -> actual is : " + exercises.ReplaceGoodWithBad("gOOd"));
                            Console.WriteLine("Expected bad -> actual is : " + exercises.ReplaceGoodWithBad("GoodG3oodGo2odGoo4d"));
                            break;
                        default:
                            Console.WriteLine("choose between 1-5 for exercises or 0 to go back to categories");
                            break;
                    }
                }
            }
        }
    }
}
