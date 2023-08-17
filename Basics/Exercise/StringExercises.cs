using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class StringExercises
    {
        public bool CheckBracketsSequence(string brackets)
        {
            /* Exercise text:
             * Given a sequence of brackets, write a method that checks if it has the same number of opening and closing brackets.
                Expected input and output
                CheckBracketsSequence("((()))") → true

                CheckBracketsSequence("()(())(") → false

                CheckBracketsSequence(")") → false
             */

            bool isThereEqualNumberOfBrackets = false;
            int numberOfLeftBrackets = 0;
            int numberOfRightBrackets = 0;

            foreach (char c in brackets)
            {
                if (c == '(')
                {
                    numberOfLeftBrackets++;
                }
                else if (c == ')')
                {
                    numberOfRightBrackets++;
                }
            }

            if (numberOfLeftBrackets == numberOfRightBrackets)
            {
                isThereEqualNumberOfBrackets = true;

            }

            return isThereEqualNumberOfBrackets;

        }

        public string AddSeperator(string text, string seperator)
        {
            /* Exercise text:
             * 
             * Given a string and a separator, write a method that adds separator between each adjacent characters in a string.
                    Expected input and output
                    AddSeparator("ABCD", "^") → "A^B^C^D^"

                    AddSeparator("chocolate", "-") → "c-h-o-c-o-l-a-t-e"
             */

            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    char c2 = text[i];
                    result += c2;
                }
                else
                {
                    char c = text[i];
                    result += c + seperator;
                }

            }

            return result;
        }

        public bool IsPalindrome(string text)
        {
            /* Exercise text:
             * Given a string, 
             * write a method that checks if it is a palindrome 
               (is read the same backward as forward). 
             * Assume that string may consist only of lower-case letters.
                Expected input and output
                IsPalindrome("eye") → true

                IsPalindrome("home") → false
             */

            bool isPalindrome = false;
            string reversedText = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            if (reversedText.Equals(text))
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        public int LengthOfAString(string text)
        {
            /* Exercise text:
             * Given a string, write a method that returns its length. 
             * Do not use library methods!
             * 
                Expected input and output
                LengthOfAString("computer") → 8

                LengthOfAString("ice cream") → 9
             */

           int length = 0;
            foreach (char c in text)
            {
                length++;
            }

            return length;


        }

        public string StringInReverseOrder(string text)
        {

            /* Exercise text:
             * Given a string, write a method that returns that string in reverse order.
                Expected input and output
                StringInReverseOrder("qwerty") → "ytrewq"

                StringInReverseOrder("oe93 kr") → "rk 39eo"
             */
            string reversedText = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }

        public int SumDigitsInString(string text)
        {
            /* Exercise text:
             * Given a string, 
             * write a method which returns sum of all digits in that string. 
             * Assume that string contains only single digits.
                Expected input and output
                SumDigitsInString("1q2w3e") → 6

                SumDigitsInString("L0r3m.1p5um") → 9

                SumDigitsInString("") → 0
             */

            int sum = 0; // value to return
            foreach (char c in text) // accessing every character in the string 
            {
                if (c >= '0' && c <= '9')//testing if each string character is in the range of 0-9 which then means it is a number
                {
                    int digit = c - 48;
                    sum += digit;
                }
            }
            return sum;
        }

        public string MakeUppercase(string text)
        {
            /* Exercise text:
             * Given a string, write a method that returns new string in which every odd letter of the word is uppercase. String may consist of one or more words.
                Expected input and output
                MakeUppercase("modem") → "MoDeM"

                MakeUppercase("BookWorm") → "BoOkWoRm"

                MakeUppercase("Aliquam dolor nisl?") → "AlIqUaM DoLoR NiSl?"
             */

            string changedText = string.Empty; // text to return
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i]; // accessing each character in the string
                if (c != ' ')
                {
                    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') // is the character a Letter
                    {

                        if (i % 2 != 0 && i != 0) //  determine if character position is even 
                        {
                            if (c >= 'A' && c <= 'Z')
                            {
                                // on even pos if it is uppercase -> change to lower case.
                                int unicodeChange = c + ('a' - 'A');
                                c = (char)unicodeChange;

                            }
                        }
                        else // determine if character position is odd 
                        {
                            // on odd pos if it is lowercase -> change to uppercase case.
                            if (c >= 'a' && c <= 'z')
                            {
                                int unicodeChange = c - ('a' - 'A');
                                c = (char)unicodeChange;
                            }

                        }
                    }
                }
                changedText += c;
            }
            return changedText;
        }

        public string MixTwoStrings(string firstText, string secondText)
        {

            /* Exercise text:
             * Given two strings, write a method that returns one string made of two strings. 
             * First letter of new string is first letter of first string, second letter of new string is first letter of second string and so on.
                    Expected input and output
                    MixTwoStrings("aaa", "BBB") → "aBaBaB"

                    MixTwoStrings("good one", "111") → "g1o1o1d one"
             */

            string newString = string.Empty;

            int totalLength = firstText.Length + secondText.Length;
            int indexFirstText = 0;
            int indexSecondText = 0;

            for (int i = 0; i < totalLength; i++)
            {
                if (indexFirstText < firstText.Length)
                {
                    newString += firstText[indexFirstText];
                    indexFirstText++;

                }

                if (indexSecondText < secondText.Length)
                {
                    newString += secondText[indexSecondText];
                    indexSecondText++;
                }
            }

            return newString;
        }

        public int NumberOfWords(string text)
        {
            /* Exercise text
             * Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
                Expected input and output
                NumberOfWords("This is sample sentence") → 4

                NumberOfWords("OK") → 1
             */
            int numberOfWords = 0;
            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if(c.Equals(' '))
                {
                    numberOfWords++;
                }
                if(i == text.Length-1)
                {
                    if (text[i] != ' ')
                    {
                        numberOfWords++;
                    }
                }
            }

            return numberOfWords;
        }

        public string RevertWordsOrder (string text)
        {
            /* Exercise text
             * Given a string, 
               write a method that returns new string with reverted words order. 
               Pay attention to the punctuation at the end of the sentence (period).
                Expected input and output
                RevertWordsOrder("John Doe.") → "Doe John."

                RevertWordsOrder("A, B. C") → "C B. A,"
             */

            string wordsOrderReversed = string.Empty;
            string tempWord = string.Empty;
            string[] tempWordsStorage = new string[text.Length];
            int whereInArray = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    char c = text[i];
                    if(c != '.')
                    {
                        tempWord += text[i];
                    }             
                    else if (i == text.Length-1)
                    {
                        tempWordsStorage[whereInArray] = tempWord;
                        whereInArray++;
                        tempWordsStorage[whereInArray] = ".";
                        tempWord = string.Empty;
                    }
                    else
                    {
                        tempWord += text[i]; // in case of a b. vc.
                        tempWordsStorage[whereInArray] = tempWord;
                        whereInArray++;
                        tempWord = string.Empty;
                    }

                }
                else if (text[i] == ' ')
                {
                    tempWordsStorage[whereInArray] = tempWord;
                    whereInArray++;
                    tempWordsStorage[whereInArray] = " ";
                    whereInArray++;
                    tempWord = string.Empty;
                }
                
            }

            string period = string.Empty;
            for(int i = tempWordsStorage.Length - 1; i >=0; i--)
            {
                if (tempWordsStorage[i] != null)
                {
                    if (tempWordsStorage[i].Equals(".") && i == tempWordsStorage.Length - 1)
                    {
                        period = tempWordsStorage[i]; // saving the period at the end of the sentence
                    }
                    else
                    {
                        if (tempWordsStorage[i].Equals("."))
                        {
                            if (tempWordsStorage[i + 1] == null)
                            {
                                if (period == string.Empty)
                                {
                                    period = tempWordsStorage[i]; // saving the period at the end of the sentence
                                }
                            }
                            else
                            {
                                wordsOrderReversed += tempWordsStorage[i];
                            }
                        }
                        else
                        {
                            wordsOrderReversed += tempWordsStorage[i];
                        }

                    }

                }
            }

            wordsOrderReversed += period;

            return wordsOrderReversed;
        }

        public int HowManyOccurrences (string text, string substring)
        {
            /* Exercise text
             * Given a string and substring, write a method that returns number of occurrences of substring in the string. Assume that both are case-sensitive. You may need to use library function here.
                Expected input and output
                HowManyOccurrences("do it now", "do") → 1

                HowManyOccurrences("empty", "d") → 0
             */

            string[] texts = new string[text.Length];
            string tempWord = string.Empty;
            int positionInArray = 0;
            int countOfWord = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i]; 
                if(c != ' ')
                {
                    tempWord += c;
                    if(i == text.Length-1)
                    {
                        texts[positionInArray] = tempWord;
                        positionInArray++;
                    }
                }
                else if (c == ' ')
                {
                    texts[positionInArray] = tempWord;
                    positionInArray++;
                    tempWord = string.Empty;
                }
            }

            // searching for the occurrences of the substring (argument 2)

            foreach (string s in texts)
            {
                if(s != null)
                {
                    if (s.Equals(substring))
                    {
                        countOfWord++;
                    }
                }

            }
            return countOfWord;
        }

        public void SortCharactersDescending(string text)
        {
            /* Exercise text
             * Given a string, 
             * write a method that returns array of chars (ASCII characters) sorted in descending order.
                Expected input and output
                SortCharactersDescending("onomatopoeia") → tpoooonmieaa

                SortCharactersDescending("fohjwf42os") → wsoojhff42
             */

            char[] result = text.ToCharArray();

            for (int i = 0; i < result.Length -1; i++)
            {
                for(int j = i+1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        char c1 = result[i];
                        char c2 = result[j]; 
                        char temp = ' '; 
                        temp = c1;
                        c1 = c2;
                        c2 = temp;
                        result[i] = c1;
                        result[j] = c2;
                        i = -1;
                        break;
                    }
                }
            }
            PrintSortingArray(result);
        }

        private void PrintSortingArray (char[] array)
        {
            foreach (char c in array)
            {
                Console.Write(c);

            }
            Console.WriteLine();
        }

        public string CompressString(string text)
        {
            /* TOOK 24 min.
             * Given a non-empty string, write a method that returns it in compressed format.
                Expected input and output
                CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"

                CompressString("p555ppp7www") → "p153p371w3"
             */

            string compressed = string.Empty;
            int countOfCharacter = 0; // counting how many characters there is.
            char tempChar = text[0]; // differentiate between different charachters
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i]; // access the charachters 
                if (c != tempChar)
                {
                    
                    compressed += tempChar.ToString() + countOfCharacter;
                    tempChar = c;
                    countOfCharacter = 1;

                }
                else
                {
                    if(i == text.Length-1)
                    {
                        countOfCharacter++;
                        compressed += tempChar.ToString() + countOfCharacter;
                    }
                    else
                    {
                        countOfCharacter++;
                    }
                    
                }



            }
            return compressed;
        }

    }
}
