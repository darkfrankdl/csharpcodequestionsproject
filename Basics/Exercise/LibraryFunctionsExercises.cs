using System.Security.Cryptography.X509Certificates;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class LibraryFunctionsExercises
    {
        public double NegativeOrPositive(double number)
        {

            /* Exercise text
             * Given a number, write a method that returns number to the power of 2 if negative or square root if positive or zero.
                Expected input and output
                NegativeOrPositive(-2) → 4

                NegativeOrPositive(6.25) → 2.5
             */
            double result = 0;
            if(number < 0)
            {
                result = Math.Pow(number, 2);
            }
            else if (number >= 0)
            {
                result = Math.Sqrt(number);
            }
            return result;
        }

        public string ReplaceXWithY(string text)
        {
            /* Exercise text
             * Write a method that replaces every letter 'y' in the string with 'x'. Assume that string contains only lower case letters.
                Expected input and output
                ReplaceXWithY("yellow") → "xellow"

                ReplaceXWithY("mushroom") → "mushroom"
             */

            string result = string.Empty;

            result = text.Replace("y", "x");

            return result;
        }

        public string ToLowerOrToUpper(string text)
        {
            /* Exercise text
             * Given a string which has at least two words separated by space, write a method that changes first word in the string to upper case, second to lower case and so on.
                Expected input and output
                ToLowerOrToUpper("this is it") → "THIS is IT"
             */
            string result = string.Empty;
            string[] words = text.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if(i % 2 == 0)
                {
                    string tempToUpper = words[i];
                    tempToUpper= tempToUpper.ToUpper();
                    words[i] = tempToUpper;
                    
                }
                else if (i % 2 != 0)
                {
                    string tempToLower = words[i];
                    tempToLower = tempToLower.ToLower();
                    words[i] = tempToLower;
                }
                result = string.Join(" ", words);
            }
            return result;
        }

        public double? GreaterNumber(double firstNumber , double secondNumber)
        {
            /* Exercise text
             * Given two numbers, write a method that returns greater one.
                Expected input and output
                GreaterNumber(2.1, 3) → 3

                GreaterNumber(-5, 0) → 0

                GreaterNumber(-111.22,111.222) → 111.222
             */
            double? result = null;
            int comparisonResult = firstNumber.CompareTo(secondNumber);
            if (comparisonResult == 1)
            {
                result = firstNumber;
            }
            else if (comparisonResult <0)
            {
                result = secondNumber;
            }
            return result;
        }

        public string IfStartsWithLowerCase(string text)
        {
            /* Exercise text
             * Given a string, write a method that checks if each word in the string starts with lower case and if so, 
               removes this letter from the string.
                Expected input and output
                IfStartsWithLowerCase("Alfa Beta gamma") → "Alfa Beta amma"
             */
            string result = string.Empty;
            string[] words = text.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (Char.IsLower(word[0]))
                {
                    words[i] = word.Substring(1);
                }
            }
            result = string.Join(" ", words);
            return result;
        }
    }
}