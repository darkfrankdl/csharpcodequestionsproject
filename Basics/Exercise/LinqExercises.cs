using System;
using System.Xml.XPath;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class LinqExercises
    {

        internal int ArraysDotProduct(int[] first , int[] second)
        {
            /* Exercise text:
             * Write a query that returns dot product of two arrays.
                Expected input and output
                [1, 2, 3], [4, 5, 6] → 32

                [7, -9, 3, -5], [9, 1, 0, -4] → 74
             */
            int i = 0;
            var result = first.Sum(
                (number) =>
                {
                    int x = 0;
                    x = number * second[i];
                    i++;
                    return x;
                }
                );

            return result;
        }

        internal string DaysNames()
        {

            /* Exercise text:
             * Write a query that returns names of days.
                Expected input and output
                daysNames → "Sunday Monday Tuesday Wednesday Thursday Friday Saturday"
             */

            string[] dayNames = new string[]
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
            };

            string result = string.Empty;
            result = string.Join(" ", dayNames.Select((s) => s));
            return result;
        }

        internal string DecryptNumber(string text)
        {
            /* Exercise text:
             * Given a non-empty string consisting only of special chars (!, @, # etc.), 
             * return a number (as a string) where each digit corresponds to given special char on the 
             * keyboard ( 1→ !, 2 → @, 3 → # etc.).
                Expected input and output
                "())(" → "9009"

                "*$(#&" → "84937"

                "!!!!!!!!!!" → "1111111111"
             */

            char[] speicalChars = new char[] {'!', '@', '#', '$', '%', '&', '/', '(', ')', '=' };

            IEnumerable<string> decryptedNumber;

            decryptedNumber = text.Select((c) => 
            {
                int i = Array.IndexOf(speicalChars, c);
                i++;
                if(i == 10)
                {
                    i = 0;
                }
                return i.ToString();
            }
            );

            string result = string.Join("", decryptedNumber);
            return result;
        }

        internal string DoublesLetters()
        {
            /* Exercise text:
             * Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ
                Expected input and output
                (no input) → "AA AB AC ... AZ BA BB ... ZX ZY ZZ"
             */ 
            List<string> letterCombos = new List<string>();
            string result = string.Empty;
            for(int firstLetter = 65; firstLetter < 90+1; firstLetter++)
            {
                for (int secondLetter = 65; secondLetter < 90+1; secondLetter++)
                {
                    string s = "" + Convert.ToChar(firstLetter) + Convert.ToChar(secondLetter);
                    letterCombos.Add(s);
                }
            }

            result = string.Join(" ", letterCombos.Select(x => x.ToString()));
            return result;

        }

        internal void FrequencyOfLetters(string text)
        {
            /* Exercise text:
             * Write a query that returns letters and their frequencies in the string.
                Expected input and output
                "gamma" → "Letter g occurs 1 time(s), Letter a occurs 2 time(s), Letter m occurs 2 time(s)"
             */

            var letters = text.GroupBy(x => x);
            foreach (var l in letters)
            {
                Console.WriteLine($"Letter {l.Key} occurs {l.Count()} Times");
            }
        }

        internal string LastWordContainingLetter(string[] words)
        {
            /* Exercise text:
             * Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
                Expected input and output
                ["plane", "ferry", "car", "bike"]→ "plane"
             */

            words.ToList().Sort();
            return string.Join("", words.First(x => x.Contains("e")));
        }

        internal string MinimumLength(string[] words)
        {
            /* Exercise text:
             * Write a query that returns words at least 5 characters long and make them uppercase.
                Expected input and output
                "computer", "usb" → "COMPUTER"
             */

            var temp = words.Where((x) => x.Length >= 5);
            return string.Join(" ", temp.Select((x)=> x.ToUpper()));
        }

        internal string MostFrequentCharacter(string text)
        {
            /* Exercise text:
             * Write a query that returns most frequent character in string. Assume that there is only one such character.
                Expected input and output
                "panda"  → 'a'

                "n093nfv034nie9"→ 'n'
             */
            int i = 0;
            var temp = text.GroupBy(x => x).OrderBy((y) => y.Count()).Last().Key;
            return string.Join("", $"most frequent character is {temp} in {text}");
        }

        internal IEnumerable<int> NumbersFromRange(int[] numbers)
        {

            /* Exercise text:
             * Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
                Expected input and output
                [67, 92, 153, 15] → 67, 92
             */
            List<int> results = new List<int>();
            var temp = numbers.OrderBy((x) => x).Where((i) => i<=100 && i >= 30);
            foreach(var num in temp)
            {
                results.Add(num);

            }

            return results;
        }

        internal string ReplaceSubstring(string[] words)
        {
            /* Exercise text:
             * Write a query that replaces 'ea' substring with astersik (*) in given list of words.
                Expected input and output
                "learn", "current", "deal" →  "l*rn", "current", "d*l"
             */

            var result2 = words.Select(
                (s)=>
                {
                    string x = string.Empty;
                    if(s.Contains("ea"))
                    {
                        x = s.Replace("ea", "*");
                    }
                    else
                    {
                        x= s ;
                    }
                    return x;
                }
                ); 
            return string.Join(" ", result2);
        }

        internal string SelectWords(string[] words)
        {
            /* Exercise text:
             * Write a query that returns words starting with letter 'a' and ending with letter 'm'.
                Expected input and output
                "mum", "amsterdam", "bloom" → "amsterdam"
             */

            var linqResult = words.Where((s) => s.First() == 'a' && s.Last() == 'm').Select((s2) => s2);
            return string.Join(" ", linqResult);
        }

        internal int [] ShuffleAnArray(int[] numbers)
        {
            /* Exercise text:
             * Write a query that shuffles sorted array.
                Expected input and output
                [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] → [4, 9, 3, 5, 2, 10, 1, 6, 8, 7]

                [38, 24, 8, 0, -1, -17, -33, -100] → [0, -100, -17, 38, 8, -1, 24, -33,]
             */
            Random rnd = new Random();
            var result = numbers.OrderBy((i) => rnd.Next()).ToArray();

            return result;
        }

        internal void SquareGreaterThan20(double[] numbers)
        {
            /* Exercise text:
             * Write a query that returns list of numbers and their squares only if square is greater than 20
                Expected input and output
                [7, 2, 30] → 7 - 49, 30 - 900
             */
            List<double> numberAndTheirSqures = new List<double>();
            var v = Math.Pow(numbers[0], 2);
            var result = numbers.Where((num) =>num * num > 20);
            numberAndTheirSqures = result.ToList();

            foreach( var number in result )
            {
                Console.Write($"{number} - {number * number} ,");
                
            }
             Console.WriteLine();
        }

        internal List<int> Top5Numbers(int[] integers)
        {
            /* Exercise text:
             * Write a query that returns top 5 numbers from the list of integers in descending order.
                Expected input and output
                [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
             */

            var result = integers.OrderByDescending((i)=>i).Take(5).ToList();
            return result;
        }

        internal List<int> TransposeAnArray(int[,] numbers)
        {
            /* Exercise text:
             * Write a query that transposes square array (switch rows with columns).
                Expected input and output
                [1,1,1,1    [1,2,3,4

                 2,2,2,2     1,2,3,4

                 3,3,3,3   → 1,2,3,4

                 4,4,4,4]    1,2,3,4]
             */
            int iRight = 0;
            int iLeft = 0;
            var result = numbers.Cast<int>().ToList();
            var result2 = result.Select((e) =>
            {
                int numToReturn = -1;
                if (iLeft < 3)
                {
                    numToReturn = numbers[iLeft, iRight];
                    iLeft++;
                }
                else if (iLeft == 3)
                {
                    numToReturn = numbers[iLeft, iRight];
                    iLeft = 0;
                    iRight++;
                }
                return numToReturn;
            }
            ).ToList();


            return result2;
        }

        internal string UniqueValues(string[] words)
        {
            /* Exercise text:
             * Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
                Expected input and output
                ["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]
             */

            var result = words.GroupBy((s) => s).Where((group)=> group.Count() == 1).Select((group)=> group.Key );
            return string.Join(" " + ", ", result);

        }

        internal string UppercaseOnly(string text)
        {
            /* Exercise text:
             * Write a query that returns only uppercase words from string.
                Expected input and output
                "DDD example CQRS Event Sourcing" → DDD, CQRS
             */

            string[] individualWords = text.Split(' ');
            var result = individualWords.GroupBy((s) => s.Equals(s.ToUpper()) ? s :"").Where((group)=> group.Key != "").Select((group) => group.Key);
            return string.Join(" ", result);
        }
    }
}