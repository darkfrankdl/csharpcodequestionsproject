using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry
{
    internal class Utility
    {
        /// <summary>
        /// Prints the help line in the console
        /// </summary>
        internal void PrintHelpOption()
        {
            Console.WriteLine("for help type \"help\"");
        }
        /// <summary>
        /// Print the console output when returning from a category to all categories to chose a new one
        /// </summary>
        internal void OnReturnToCategoies(string[] categoryChoses)
        {
            PrintTheTitleForACategory("Categories");
            HelpText(categoryChoses);
            PrintHelpOption();
        }
        /// <summary>
        /// Prints the title for the categories 
        /// </summary>
        internal void PrintTheTitleForACategory(string titleName)
        {
            Console.WriteLine($"******** {titleName} ********+ \n");
        }
        /// <summary>
        /// prints the quit text in the console
        /// </summary>
        internal void PrintQuitOption()
        {
            Console.WriteLine("Quit type q");
        }
        /// <summary>
        /// prints the text for the option to return to the categories 
        /// </summary>
        internal void PrintBackToCategoriesOption()
        {
            Console.WriteLine("0 for go back to categories");
        }
        /// <summary>
        /// prints the help text when typing "help" typically all the available options for the user.
        /// </summary>
        /// <param name="choses"></param>
        internal void HelpText(string[] choses)
        {

            for (int i = 0; i < choses.Length; i++)
            {
                Console.WriteLine($"{i + 1} for {choses[i]} ");
            }
        }

        internal void PrintExerciseTextNonEnumerables<T> (string expectedOutput, T t)
        {
            Console.WriteLine($"Expected output : {expectedOutput} -> actual output : " + t);

        }
        internal void PrintExerciseTextEnumerables<T>(string expectedOutput, IEnumerable<T> t)
        {
            string toPrint = string.Empty;
            foreach(var x in t)
            {
                toPrint += x + " " ;
            }

            Console.WriteLine($"Expected output : {expectedOutput} -> actual output : " + toPrint);

        }
    }
}
