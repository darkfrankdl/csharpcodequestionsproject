using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class LoopsExercises
    {
        public void MultiplicationTable()
        {
            // Exercise text:
            //Write a method that prints 10 by 10 multiplication table.
            //Remember about readibility (spaces in the right place).

            //Expected input and output
            //1  2  3  4  5  6  7  8  9 10

            //2  4  6  8 10 12 14 16 18 20

            //3  6  9 12 15 18 21 24 27 30

            //4  8 12 16 20 24 28 32 36 40

            //5 10 15 20 25 30 35 40 45 50

            //6 12 18 24 30 36 42 48 54 60

            //7 14 21 28 35 42 49 56 63 70

            //8 16 24 32 40 48 56 64 72 80

            //9 18 27 36 45 54 63 72 81 90

            //10 20 30 40 50 60 70 80 90 100


            // structure: the below line and the loop structures. 
            int[,] table = new int[10, 10];


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // scalculate the numbers
                    int column = i + 1;
                    int row = j + 1;
                    int multiplication = column * row;
                    // POPULATING THE TABLE
                    table[i, j] = multiplication;


                    if (column == 1) // format for the very first row number from 1-10
                    {
                        if (column * row < 10) // numbers 1-9
                        {
                            PrinterHelperToMultiplicationTable(true, table[i, j], true);
                        }
                        else // number 10 
                        {
                            PrinterHelperToMultiplicationTable(false, table[i, j], true);
                        }
                    }
                    else if (column > 1 && column * row < 10) // for all numbers in the range of 1-10 in all rows except the first.
                    {
                        PrinterHelperToMultiplicationTable(true, table[i, j], true);
                    }
                    else if (column > 1 && column * row >= 10) // for all numbers in the range of 10-100 in all rows except the first.
                    {
                        PrinterHelperToMultiplicationTable(false, table[i, j], true);
                    }

                }

                Console.WriteLine("\n"); //  having space between the rows (vertical spaces)
            }

        }

        private void PrinterHelperToMultiplicationTable(bool WhiteSpaceBefore, int numberToPrint, bool WhiteSpaceAfter)
        {
            if (WhiteSpaceBefore && WhiteSpaceAfter)
            {
                Console.Write(" " + numberToPrint + " ");
            }
            else if (WhiteSpaceBefore && !WhiteSpaceAfter)
            {
                Console.Write(" " + numberToPrint + "");
            }
            else if (!WhiteSpaceBefore && WhiteSpaceAfter)
            {
                Console.Write("" + numberToPrint + " ");
            }
            else if (!WhiteSpaceBefore && !WhiteSpaceAfter)
            {
                Console.Write("" + numberToPrint + "");
            }
        }

        public double FractionsSum(int numberOfSeries)
        {
            // Exercise text:
            // Given an integer n, write a method that returns the sum 
            // of series 1+ 1/2^2 + 1/3^2 + ... + 1/n^2
            // Libary functions is illigal

            // expected input and output 
            // FractionsSum(3) -> 1,36111111111
            // FractionsSum(5) → 1.46361111111111

            double resultToReturn = 1.0;

            for (int i = 2; i <= numberOfSeries; i++)
            {
                double temp = 1.0 / i * (1.0 / i);
                resultToReturn = resultToReturn + temp;
            }
            return resultToReturn;

        }

        public void SortArrayAscending(int[] toSort)
        {
            /* Exercise text:
             * Given an array of integers, 
             * write a method that returns sorted array in ascending order.
             * 
             *  Expected input and output
             *  SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9]
             */

            for (int i = 0; i < toSort.Length - 1; i++)
            {
                int leftElementForComparison = toSort[i];
                bool goon = true;
                for (int j = i + 1; j < toSort.Length && goon; j++)
                {
                    int rightElementForComparison = toSort[j];

                    if (rightElementForComparison < leftElementForComparison) // not ordered
                    {
                        // swapping
                        toSort[j] += toSort[i];

                        toSort[i] += rightElementForComparison;

                        toSort[i] -= leftElementForComparison;

                        toSort[j] -= rightElementForComparison;

                        goon = false;
                        i = -1;
                    }
                }
            }

            PrintArrayHelperToSortArrayAscending(toSort);

        }

        private void PrintArrayHelperToSortArrayAscending(int[] toSort)
        {
            foreach (int i in toSort)
            {
                Console.Write(i + " ");
            }
        }

        public int? TheBiggestNumber(int[] integers)
        {
            /*
             * Exercise text:
             * Given an array of integers, write a method that returns the biggest number in this array.
                Expected input and output
                TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 300
                TheBiggestNumber([-9, -2, -7, -8, -4]) → -2
             *
             *
             */

            int? theBiggestNumber = null; // saving the number

            foreach (int i in integers) //access every element in the array
            {
                if (theBiggestNumber == null)
                {
                    theBiggestNumber = i;
                }
                else if (theBiggestNumber != null)
                {
                    //  compare the numbers to eachother as the array is gone thougth.
                    if (i > theBiggestNumber)
                    {
                        theBiggestNumber = i;
                    }
                }
            }

            return theBiggestNumber;
        }

        public int Two7sNextToEachOther(double[] digits)
        {
            /* Exercise text:
             * 
             * Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
                Expected input and output
                Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1
                Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 ]) → 3
            *
            */
            int tracking7pairs = 0;


            for (int i = 0; i < digits.Length - 1; i++)
            {
                // acccess

                double firstNumber = digits[i];
                double secondNumber = digits[i + 1];

                // comparison 
                if (firstNumber == 7 && secondNumber == 7)
                {
                    tracking7pairs += 1;
                }
            }


            return tracking7pairs;
        }

        public bool ThreeIncreasingAdjacent(int[] numbers)
        {
            /*
             * Exercise text:
             * Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.
                Expected input and output
                ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True

                ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False
             */

            bool isThereThreeNumbersAdjacentIncreasing = false;
            bool goon = true;

            for (int i = 0; i < numbers.Length - 2 && goon; i++) 
            {
                // accessing 

                int firstNumber = numbers[i];
                int secondNumber = numbers[i + 1];
                int thirdNumber = numbers[i + 2];

                // comparison

                if (firstNumber == secondNumber - 1 && thirdNumber == secondNumber + 1)
                {
                    isThereThreeNumbersAdjacentIncreasing = true;
                    goon = false;
                }
            }

            return isThereThreeNumbersAdjacentIncreasing;
        }

        public string ReturnEvenNumbers()
        {
            /*
             * Exercise text:
             * Write a method that returns a string 
             * of even numbers greater than 0 and less than 100.
                    Expected input and output
                    ReturnEvenNumbers() → 
            "2 4 6 8 10 12 14 16 18 20 22 
            24 26 28 30 32 34 36 38 40 42 44 
            46 48 50 52 54 56 58 60 62 64 66 68 
            70 72 74 76 78 80 82 84 86 88 90 92 
            94 96 98"

             */

            string evenNumbersFromTwoToOnehundred = "";

            for (int i = 2; i < 100; i += 2)
            {
                evenNumbersFromTwoToOnehundred += i + " ";
            }

            return evenNumbersFromTwoToOnehundred;
        }

        public void SieveOfEratosthenes(int n)
        {
            /*
             * Exercise text:
             * Given an integer n (n>2), 
               write a method that returns prime numbers from range [2, n].
             * Expected input and output
                SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]
             */

            // definition of prime numbers is 
            /*
             * natural number 
             * divisiable by excatly 2 other natural numbers (division = whole number) that is 1 and the number itself.
               thus also that the prime number is not a product of other numbers except 1 * n
             */


            int[] primeNumbers = new int[n]; // here the numbers are stored.

            // finding  prime numbers
            for (int i = 2; i <= n; i++)
            {

                bool isDivisiableByOther = false;
                bool goon = true;

                for (int j = 2; j < i && goon; j++)
                {
                    int divisiableByOther = i % j;

                    if (divisiableByOther == 0)
                    {
                        goon = false;
                        isDivisiableByOther = true;
                    }


                }

                // prime number if j loop does not stop by goon condition

                if (!isDivisiableByOther)
                {
                    bool goonForAdding = true;
                    // putting numbers inside the array defined above.
                    for (int k = 0; k < primeNumbers.Length && goonForAdding; k++)
                    {
                        if (primeNumbers[k] == 0)
                        {
                            primeNumbers[k] = i;
                            goonForAdding = false;
                        }
                    }
                }
            }

            PrintPrimeNumbers(primeNumbers);
        }

        private void PrintPrimeNumbers(int[] primeNumbers)
        {
            foreach (int i in primeNumbers)
            {
                if (i != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }


        public void DrawHourGlass()
        {
            /* Exercise text:
             * Write a method that draws hourglass shape like below.
                Expected input and output
                DrawHourglass() →

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

                ***********
             */

            string[] stars = new string[11];

            stars[5] = "*";

            //  structure of the hourglass
            string currentStars = "*";
            for (int i = 4; i >= 0; i--)
            {
                // calculate the stars to add
                currentStars = currentStars + "*";
                currentStars = "*" + currentStars;

                stars[i] = currentStars;
            }
            currentStars = "*"; // necessary to get the correct number of stars in the loop below added to the array on positions 6 till array.length
            for (int i = 6; i < stars.Length; i++)
            {
                // calculate the stars to add
                currentStars = currentStars + "*";
                currentStars = "*" + currentStars;

                stars[i] = currentStars;
            }

            // printing the hourglass.

            string starLevel = "";
            for (int i = 0; i < stars.Length; i++)
            {
                if (i == 0 || i == stars.Length - 1)
                {
                    Console.WriteLine(stars[i]);
                }
                else
                {
                    starLevel += " ";
                    Console.WriteLine(starLevel + stars[i]);
                }

                if (i == 5)
                {
                    starLevel = "   ";
                }
                else if (i == 6)
                {
                    starLevel = "  ";
                }
                else if (i == 7)
                {
                    starLevel = " ";
                }
                else if (i == 8)
                {
                    starLevel = "";

                }
            }
        }

        public void DrawParallelogram()
        {
            /*
             * Exercise text:
             * Write a method that draws parallelogram shape like below.
                Expected input and output
                DrawParallelogram() →

                     ***************

                    ***************

                   ***************

                  ***************

                 ***************
             */

           // STRUCTURE -> array structure to hold the strings 

            string[] structure = new string[5];
            string whitespace = "";
            for (int i = 0; i < structure.Length; i++)
            {
                structure[i] = whitespace + "***************"; // this is calculating the stars but these are predefined how many there is.
                whitespace = whitespace + " ";

            }
            for (int j = structure.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(structure[j]); // printing the level.
            }

        }

        public void DrawChristmasTreeOnlyLoops()
        {
            /* Exercise text:
             * Write a method that draws Christmas tree shape like below.
                    Expected input and output
                    DrawChristmasTree() →

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

                    *******
             */

           for (int group = 0; group < 3; group++)
            {
                for (int level = 0; level < 4; level++)
                {
                    for (int whitespace = 0; whitespace < 3 - level; whitespace++)
                    {
                        Console.Write(" ");
                    }

                    for (int stars = 0; stars < 7 - (6 - level - level); stars++)
                    {
                        Console.Write("*");
                    }

                    for (int whitespace = 0; whitespace < 3 - level; whitespace++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

            }
        }

        public void ExtractString(string word)
        {
            /* Exercise text:
             * Given a string, write a method that returns substring from between two double hash signs (#).
                Expected input and output
                ExtractString("##abc##def") → "abc"

                ExtractString("12####78") → empty string

                ExtractString("gar##d#en") → empty string

                ExtractString("++##--##++") → "--"
             */

            // finding the ## ##:
            // strategy is to make a char array from the paramter word and then search for the ## ## if it exist and save indexes
            char[] chars = word.ToCharArray();

            List<int> indexes = new List<int>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '#')
                {
                    indexes.Add(i);
                }
            }

            int[] indexesArray = indexes.ToArray();
            string[] substrings = new string[indexesArray.Length];
            string toPutIntoTheArrayForPrinting = "";
            if (indexesArray.Length % 2 == 0 && indexesArray.Length >= 4) // -> eliminates uneven ## pairs thus eliminates where a pair only consists of # and starts at 2 pairs of ## ##
            {
                for (int i = 0; i < indexesArray.Length - 3; i += 2) // controls the list where the indexes of the ## from the string is located.
                {
                    if (indexesArray[i] == indexesArray[i + 1] - 1) // is the first pair of ## neighbors 
                    {
                        if (indexesArray[i + 2] == indexesArray[i + 3] - 1) // is the second pair of ## neighbors 
                        {
                            // there exist a ## ... ## Now take everything between and save in a variable named toPutIntoTheArrayForPrinting

                            for (int j = indexesArray[i + 1] + 1; j < indexesArray[i + 2]; j++) // take the indexes from the list and go to the char array
                            {

                                toPutIntoTheArrayForPrinting += chars[j];


                            }
                        }
                    }
                }
            }

            if (toPutIntoTheArrayForPrinting.Length > 0)
            {
                bool goon = true;
                for (int indexForSubstrings = 0; indexForSubstrings < substrings.Length && goon; indexForSubstrings++) // purpose is to put the substrings inside a array for printing
                {
                    if (substrings[indexForSubstrings] == null)
                    {
                        substrings[indexForSubstrings] = toPutIntoTheArrayForPrinting;
                        goon = false;
                    }
                }
            }

            PrintHelperToExtractStringMethod(substrings);
        }

        private void PrintHelperToExtractStringMethod(string[] arrayToPrintFrom)
        {
            foreach (string s in arrayToPrintFrom)
            {
                Console.WriteLine(s);
            }
        }

        public string FullSequenceOfLetters(string twoLetters)
        {
            /* Exercise text:
             * Given a string of two letters, 
               where first one occurs before the second in the alphabet, 
               write a method that returns full sequence of letters starting from first and ending at the second one.
                    Expected input and output
                    FullSequenceOfLetters("ds") → "defghijklmnopqrs"

                    FullSequenceOfLetters("or") → "opqr"
             */

            char[] chars = twoLetters.ToCharArray();// being able to access each letter seperately
            char firstLetter = chars[0]; // in FullSequenceOfLetters(ag) this is 'a'
            char secondLetter = chars[1]; // in FullSequenceOfLetters(ag) this is 'g'

            
            string toReturn = ""; // used for saveing the sequence.

            // determine which letters should be in between the start letter and the end letter 
            for (int i = firstLetter; i <= secondLetter; i++)
            {
                char alphabetLetter = Convert.ToChar(i);
                toReturn += alphabetLetter;
            }
            return toReturn;
        }

        public int LongestStrictlyIncreasingSequence(int[] integers)
        {
            /*
             * Exercise text:.
             * Given an array of integers,
               write a method that returns value of the longest 
               strictly increasing sequence of numbers.
             *  Expected input and output
                LongestStrictlyIncreasingSequence([0, 3, 4, 5, 6, 4, 9]) → 5

                LongestStrictlyIncreasingSequence([7, 7, 7, 7, 7]) → 0
             */

            /*
             * research a strictly increasing sequence is this 
               a<a+1 thus in the this array 0, 3, 4, 5, 6, 4, 9 the numbers through 0 to 6 is strictly increasing as each new number is bigger than the previous.
             */

            // hold the sequences of increasing numbers 
            int?[,] sequences = new int?[integers.Length, integers.Length]; // horizontal (first in the array) is the placeholder for the sequences and the second is the actual sequences
            // accsseing of the argument (array)
            int countOfNumbersInSequenceTotalLeft = integers.Length;
            for (int sequencePlaceholderNumber = 0; sequencePlaceholderNumber < countOfNumbersInSequenceTotalLeft; sequencePlaceholderNumber++)
            {
                bool goon = true;
                for (int numberInSequence = 0; numberInSequence < integers.Length && goon; numberInSequence++)
                {
                    bool goon2 = true;
                    for (int NumberInOriginalSequence = integers.Length - countOfNumbersInSequenceTotalLeft; NumberInOriginalSequence < integers.Length && goon2; NumberInOriginalSequence++)
                    {
                        int number = integers[NumberInOriginalSequence]; // access number 

                        if (sequences[sequencePlaceholderNumber, numberInSequence] == null)
                        {
                            //check for the math rule of :  a<a+1
                            if (numberInSequence == 0)
                            {
                                sequences[sequencePlaceholderNumber, numberInSequence] = number; // add number to sequence
                                countOfNumbersInSequenceTotalLeft -= 1;
                                goon2 = false;
                            }
                            else if (numberInSequence > 0)
                            {
                                // check math rule here 
                                if (number > sequences[sequencePlaceholderNumber, numberInSequence - 1])
                                {
                                    sequences[sequencePlaceholderNumber, numberInSequence] = number; // add number to sequence
                                    countOfNumbersInSequenceTotalLeft -= 1;
                                    goon2 = false;
                                }
                                else
                                {
                                    goon2 = false;
                                    goon = false;
                                }
                            }

                        }
                    }

                }
            }

            // printing the numbers in all sequences 
            int longestSequenceColumn = 0;


            for (int sequenceNumber = 0; sequenceNumber < integers.Length; sequenceNumber++)
            {
                int tempSequenceLength = 0;
                bool goon = true;
                for (int sequenceRowNumber = 0; sequenceRowNumber < integers.Length && goon; sequenceRowNumber++)
                {
                    if (sequences[sequenceNumber, sequenceRowNumber] != null)
                    {

                        tempSequenceLength += 1;
                    }
                    else
                    {
                        goon = false;
                    }

                }
                if (tempSequenceLength > longestSequenceColumn)
                {
                    longestSequenceColumn = tempSequenceLength;
                }
                if (longestSequenceColumn == 1)
                {
                    longestSequenceColumn = 0;
                }

            }
            return longestSequenceColumn;
        }

        public int BitsToNumber(string bitSequence)
        {
            /* exercise text:
             * Write a method that 
               takes non-empty string of bits as an argument 
               and returns number as integer.
             *  Expected input and output
                BitsToNumber("1") → 1

                BitsToNumber("100010") → 34
             */

            char[] bits = bitSequence.ToArray();
            int[] powerOfTwos = new int[bits.Length];
            int constant = 2;
            // adding the numbers to the int array powerOfTwos
            for (int placementInArrayPowerOfTwos = 0; placementInArrayPowerOfTwos < powerOfTwos.Length; placementInArrayPowerOfTwos++)
            {

                for (int powerOfTwo = powerOfTwos.Length - placementInArrayPowerOfTwos; powerOfTwo > 0; powerOfTwo--)
                {
                    if (powerOfTwos[placementInArrayPowerOfTwos] == 0)
                    {
                        powerOfTwos[placementInArrayPowerOfTwos] = 1;
                    }
                    else if (placementInArrayPowerOfTwos == powerOfTwos.Length - 1)
                    {
                        powerOfTwos[placementInArrayPowerOfTwos] = 1;
                    }
                    else
                    {
                        powerOfTwos[placementInArrayPowerOfTwos] *= 2;
                    }
                }
            }

            // calculating the return value 

            int toReturn = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    toReturn += powerOfTwos[i];
                }
            }
            return toReturn;
        }

        public int DigitsSumArrayVersion(int number)
        {



            /* Exercise text:
             * Given a non-negative number, 
               write a method that returns sum of its digits.
             *  Expected input and output
                DigitsSum(5434) → 16

                DigitsSum(904861) → 28
            */

            int toReturn = 0;
            string numberText = number.ToString();
            char[] digits = numberText.ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '0')
                {
                    toReturn += 0;
                }
                else if (digits[i] == '1')
                {
                    toReturn += 1;
                }
                else if (digits[i] == '2')
                {
                    toReturn += 2;
                }
                else if (digits[i] == '3')
                {
                    toReturn += 3;
                }
                else if (digits[i] == '4')
                {
                    toReturn += 4;
                }
                else if (digits[i] == '5')
                {
                    toReturn += 5;
                }
                else if (digits[i] == '6')
                {
                    toReturn += 6;
                }
                else if (digits[i] == '7')
                {
                    toReturn += 7;
                }
                else if (digits[i] == '8')
                {
                    toReturn += 8;
                }
                else if (digits[i] == '9')
                {
                    toReturn += 9;
                }
            }
            return toReturn;
        }


        public string SumAndAverage(int n, int m)
        {


            /*
             * Exercise text:
             * Given two integers n and m (n <= m), 
               write a method that returns sum of all 
               integers and average from range [n, m].
                Expected input and output
                SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5"

                SumAndAverage(-10, 0) → "Sum: -55, Average: -5"
             * 
             */

            string sumAndAverageText = "";
            int sum = 0;
            double average = 0;
            double howManyNumbersInTheRange = 0;
            if (n <= m)
            {
                for (int i = n; i <= m; i++)
                {
                    sum += i;
                    howManyNumbersInTheRange++;

                }
                average = sum / howManyNumbersInTheRange;
                sumAndAverageText = $"Sum : {sum} , Average: {average} ";
            }
            else
            {
                sumAndAverageText = $" ERROR: first number needs to be equal or less then second number ";
            }

            return sumAndAverageText;
        }

        public double SumDoubleOnly(object[] objects)
        {
            /* Exercise text:
             * Given an array of objects, write a method that returns sum of objects of double type.
                Expected input and output
                SumDoubleOnly(["abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22]) → 7.82
             */

            double sum = 0.0;
            foreach (object obj in objects)
            {
                if (obj.GetType() == typeof(double))
                {
                    double d = (double)obj;
                    sum += d;
                }
            }

            return sum;
        }

        public void DrawTriangle(int length)
        {
            /* TExercise text:
             * Write a method that draws triangle shape like below.
                    Expected input and output
                     DrawTriangle() →

                             *

                            **

                           ***

                          ****

                         *****

                        ******

                       *******

                      ********

                     *********

                    **********
             */

            for (int level = 0; level < length; level++)
            {
                for (int whiteSpace = 0; whiteSpace < length - (level + 1); whiteSpace++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < level + 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public int ToThePowerOf(int number, int power)
        {
            /*Exercise text:
             * 
                    Given two integers, write a method that returns first number raised to the power of second one.
                    Expected input and output
                    ToThePowerOf(-2, 3) → -8

                    ToThePowerOf(5, 5) → 3125
             */

            int result = number;
            for (int i = power; i > 1; i--)
            {
                result *= number * -1;
            }

            return result;
        }

        public bool LettersBalance(string text)
        {
            /* Exercise text:
             * Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string. 
               Assume string length is even and letters don't repeat on each side.
                Expected input and output
                LettersBalance("fgvgvf") → true

                LettersBalance("lampsmpser") → false
             */

            // access by splitting the string 
            char[] letters = text.ToCharArray();
            char[] leftSideOfText = new char[letters.Length / 2];
            char[] RightSideOfText = new char[letters.Length / 2];
            bool isStringBalanced = false;
            FillArraysForLettersBalance(letters, leftSideOfText, RightSideOfText);

            //comparison

            for (int letterInLeft = 0; letterInLeft < leftSideOfText.Length; letterInLeft++)
            {
                for (int letterInRight = 0; letterInRight < RightSideOfText.Length; letterInRight++)
                {
                    if (leftSideOfText[letterInLeft] == RightSideOfText[letterInRight])
                    {
                        isStringBalanced = true;
                        break;
                    }

                }
                if (!isStringBalanced)
                {
                    break;
                }
            }

            return isStringBalanced;

        }

        private void FillArraysForLettersBalance(char[] lettersTotal, char[] leftSide, char[] rightSide)
        {
            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSide[i] = lettersTotal[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSide[i] = lettersTotal[i + (lettersTotal.Length - lettersTotal.Length / 2)];
            }
        }

        public string ReplaceTwoWords(string text, char seperator)
        {
            /* Exercise text:
             * Given a string in which two words are separated by a char, 
             * write a method that replaces these two words.
                Expected input and output
                ReplaceWords("abc_xyz", '_') → xyz_abc

                ReplaceWords("trolling.master", '.') → master.trolling


             */

            /*
             * Solution:
             * take the string and make it a char array 
             *  find the seperators index in the char array save it for later use. 
             *  put the left side of the seperator inside a seperate array 
             *  put the right side of the seperator inside a seperate array 
             * form a new array (string) where the right side is first and the left is after
             * form the new string array to a string to return 
             */

            string replacedTwoWords = null;
            char[] originalString = text.ToCharArray();
            char[] replacedStringArray = null;
            char[] leftSideOfSeperator = null;
            char[] rightSideOfSeperator = null;
            int seperatorIndex = -1;

            // finding seperator index
            seperatorIndex = HelperReplaceTwoWordsFindSeperatorIndex(originalString, seperator);
            leftSideOfSeperator = new char[originalString.Length - (originalString.Length - seperatorIndex)];
            rightSideOfSeperator = new char[originalString.Length - seperatorIndex - 1];
            // seperating the string to two seperate arrays
            HelperReplaceTwoWordsFillUpArray(originalString, leftSideOfSeperator, rightSideOfSeperator, seperatorIndex);
            replacedStringArray = HelperReplaceTwoWordsFormTheNewArray(rightSideOfSeperator, leftSideOfSeperator, seperator, seperatorIndex);
            replacedTwoWords = HelperReplaceTwoWordsFormString(replacedStringArray, replacedTwoWords);
            
            return replacedTwoWords;
        }

        private string? HelperReplaceTwoWordsFormString(char[] replacedStringArray, string? replacedTwoWords)
        {
            string? replacesString = null;

            foreach (char c in replacedStringArray)
            {
                replacesString += c;
            }

            return replacesString;
        }

        private char[] HelperReplaceTwoWordsFormTheNewArray(char[] rightSideOfSeperator, char[] leftSideOfSeperator, char seperator, int seperatorIndex)
        {
            char[] replacedArray = new char[rightSideOfSeperator.Length + leftSideOfSeperator.Length + 1];
            bool isSeperatorUsed = false;
            int startIndexForRightSideOfReplacedArray = seperatorIndex + 1;
            int howManyUsedFromLeft = 0;
            for (int i = 0; i < replacedArray.Length; i++)
            {
                // isused false
                if (!isSeperatorUsed)
                {
                    if (i < rightSideOfSeperator.Length)
                    {
                        replacedArray[i] = rightSideOfSeperator[i];
                    }
                    else
                    {
                        replacedArray[i] = seperator;
                        isSeperatorUsed = true;
                    }
                }
                else if (isSeperatorUsed)
                {
                    if (i >= replacedArray.Length - seperatorIndex)
                    {
                        if (howManyUsedFromLeft <= leftSideOfSeperator.Length)
                        {
                            replacedArray[i] = leftSideOfSeperator[startIndexForRightSideOfReplacedArray - seperatorIndex - 1];
                            startIndexForRightSideOfReplacedArray++;
                            howManyUsedFromLeft++;
                        }

                    }

                }
            }
            return replacedArray;
        }

        private void HelperReplaceTwoWordsFillUpArray(char[] originalString, char[] leftSideOfSeperator, char[] rigtSideOfSeperator, int index)
        {
            int startInOriginalArray = index + 1;
            for (int i = 0; i < index; i++)
            {
                leftSideOfSeperator[i] = originalString[i];
            }
            for (int i = 0; i < originalString.Length - index - 1; i++)
            {
                if (startInOriginalArray <= originalString.Length)
                {
                    rigtSideOfSeperator[i] = originalString[startInOriginalArray];
                    startInOriginalArray++;
                }

            }
        }

        private int HelperReplaceTwoWordsFindSeperatorIndex(char[] originalString, int seperator)
        {
            int seperatorIndex = -1;
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == seperator)
                {
                    seperatorIndex = i;
                    break;
                }
            }
            return seperatorIndex;
        }

        public int DigitalRoot(int number)
        {
            /*Exercise text:
             * Given a non-negative number, write a method that returns its digital root. From Wikipedia - digital root is a value obtained by an iterative process of summing digits, on each iteration using the result from the previous iteration to compute a digit sum. The process continues until a single-digit number is reached.
                Expected input and output
                DigitalRoot(83) → 2

                DigitalRoot(40002938) → 8
             */

            int result = -1;

            int previousIterationSum = -1;
            int sum = 0;
            int num = number;
            bool goon = true;
            bool goonForLoop = true;
            while (goon)
            {
                if (previousIterationSum >= 0 && previousIterationSum <= 9)
                {
                    goon = false;
                }
                else
                {
                    for (int i = 0; goonForLoop; i++)
                    {

                        if (num != 0)
                        {

                            sum += num % 10;
                            num = num / 10;

                        }
                        else
                        {
                            goonForLoop = false;
                            previousIterationSum = sum;
                            num = previousIterationSum;
                        }
                    }
                    goonForLoop = true;
                    sum = 0;
                }


            }
            result = previousIterationSum;
            return result;
        }
    }

}
