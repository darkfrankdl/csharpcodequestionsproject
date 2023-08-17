using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class RegularExpresionExercises
    {
        /*
             * ^ - Starts with
             * $ - ends with
             * [] - range
             * . - single character
             * + - one or more characters in a row
             * ? - optional preceding character match
             * \ - escape character
             * \n - new line 
             * \d - digit
             * \D - non-digit
             * \s - whitespace
             * \S- non white space
             * \w - alphanumeric/underscore scharacter ( word chars)
             * \W - non word characters
             * {x,y} - repeat low (x) to high (y) ( no "y" means at least x, no " ,y" means that many 
             * (x|y) - alternative - x or y
             * [^x] - anything but x ( where x is whatever character you want)
             * 
             * with regex it is possible to ignore case in the pattern by RegexOptions.IgnoreCase or just have [Uppercase lowercase]
             */
        internal bool AlmostOnlyLetters(string toSearch)
        {
            /* Exercise text:
             * Given a string, 
             * write a method that checks if consists of letters only and ends with period. 
             * If string has more than one word, words are separated by space.
                Expected input and output
                AlmostOnlyLetters("She is nice.") → true

                AlmostOnlyLetters("true 222.") → false
             */

            bool result = false;

            string pattern = @"[A-Za-z\s]\.$";

            result = Regex.IsMatch(toSearch, pattern);

            return result;

        }
        
        internal bool CheckPhoneNumber(string phoneNumber)
        {
            /* Exercise text:
             * Given a phone number as a string, write a method that checks if it is in the format +XX YYY-YYY-YYY.
                Expected input and output
                CheckPhoneNumber("+35 392-022-194") → true

                CheckPhoneNumber("+958 28492-503") → false
             */

            bool result = false;
            string pattern = @"\+\d{2}\s\d{3}-\d{3}-\d{3}";
            result = Regex.IsMatch(phoneNumber, pattern);
            return result;
        }

        internal string DecimalDigitInformation(string StringWithDigit)
        {
            /* Exercise text:
             * Given a string, write a method that checks if contains decimal digit and if yes returns its value and position.
                Expected input and output
                DecimalDigitInformation("This is 9") → "Digit 9 at position 8"

                DecimalDigitInformation("ABCdef") → "No digit found!"
             */
            string result = string.Empty;
            string pattern = @"[0-9]";
            Match match = Regex.Match(StringWithDigit, pattern);
            int digitPosition = -1;
            digitPosition = match.Index;
            result = $"Digit {match.Value} at position {digitPosition}"; 
            return result;
        }

        internal bool EveryWordInTheString(string toSearch)
        {
            /* TExercise text:
             * Given a string, write a method that checks if every word begins with capital letter.
                Expected input and output
                EveryWordInTheString("Use Of Technology") → true

                EveryWordInTheString("Rocket science") → false
             */
            bool result = false;
            string pattern = @"^([A-Z][a-z]*\s*)+$";
            result = Regex.IsMatch(toSearch, pattern);
            return result;
        }

        internal string ReplaceGoodWithBad(string toSearch)
        {
            /* Exercise text:
             * Given a string, write a method that replaces every word 'good' with 'bad'. 
             * Assume that words to be replaced may consist of mixed cases (gOod, baD, etc.).
                Expected input and output
                ReplaceGoodWithBad("gOOd") → "bad"

                ReplaceGoodWithBad("so b@d") →  "so b@d"
             */

            string toSearchLowerCase = toSearch.ToLower();
            string pattern = "good";
            string replacedString = Regex.Replace(toSearchLowerCase, pattern, "bad");
            return replacedString;
        }
    }
}
