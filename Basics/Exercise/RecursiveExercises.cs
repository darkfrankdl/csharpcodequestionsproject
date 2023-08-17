using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class RecursiveExercises
    {
        int[] calculations = new int[150];
        /*
         * Step by step for solving recursive problems
         * 
         * 1) what is the simplest input = base case
         * 2) exsample and visualize as input increases from the base case 
         * 3) relate hard cases to more simplier cases -> is there any pattern. 
         * 4) generalize the pattern = your recursive case 
         * 5) combine the base case and recursive case in code.
         */


        public int DigitsMultiplication(int number)
        {
            /* Exercise text
             * Given a positive integer, write a method that returns multiplication of all digits in the number.
                Expected input and output
                DigitsMultiplication(456) → 120

                DigitsMultiplication(123) → 6
             */

            int result = 0;
            // base case 
            if (number % 10 == 0)
            {
                return result;
            }
            else // recursive case
            {
                int individualNumber = number % 10; // access the number on the far right
                int temp = individualNumber * DigitsMultiplication(number / 10);
                if (temp == 0)
                {
                    result = individualNumber;
                }
                else
                {
                    result = individualNumber * DigitsMultiplication(number / 10);
                }
                return result;

            }


        }

        public int Factorial(int number)
        {
            /* Exercise text
             * Given a non-negative integer, write a method that returns factorial of a number.
                Expected input and output
                Factorial(4) → 24

                Factorial(7) → 5040
             */

            int result = 0;
            if (number == 1)
            {
                result = 1;
            }
            else
            {
                int temp = number * Factorial(number - 1);
                result = temp;
            }

            return result;

        }

        public int FibonacciNumber(int n)
        {
            /* Exercise text
             * Given a non-negative integer, write a method that returns n-th element of Fibonacci sequence.
                Expected input and output
                FibonacciNumber(3) → 2

                FibonacciNumber(7) → 13
             */

            /*FROM WIKIPEDIA
             * F 0 = 0 , F 1 = 1 ,
               and FN = Fn − 1 + F n − 2
                for n > 1.
             */
            int fibNum = -1;
            if (n == 0)
            {
                fibNum = 0;
            }
            else if (n == 1)
            {
                fibNum = 1;
            }
            else
            {
                fibNum = FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            }

            return fibNum;
        }

        public int? NumbersMultiplication(int a, int b)
        {
            /* Exercise text
             * Given two integers a and b (a <= b) as range, write a method that returns multiplication of numbers from given range.
                    Expected input and output
                    NumbersMultiplication(5, 7) → 210

                    NumbersMultiplication(50, 50) → 50
             */


            int? result = null;
            if (a <= b)
            {
                // base case 
                if (a == b)
                {
                    result = a;
                }
                else // recursive case
                {
                    result = a * NumbersMultiplication(a + 1, b);
                }
            }
            return result;
        }

        internal int ToThePowerOfRecursion(int number, int exponent)
        {

            /* Exercise text
             * Given two integers, write a method that returns first number raised to the power of second number.
                Expected input and output
                ToThePowerOfRecursion(2, 3) → 8

                ToThePowerOfRecursion(5, 2) → 25
             */
            int result = -1;
            if (exponent == 0)
            {
                result = 1;
            }
            else
            {
                result = number * ToThePowerOfRecursion(number, exponent - 1);
            }

            return result;
        }

        public string StringInReverseOrderRecursion(string text)
        {
            /* Exercise text
             * String in reverse order (recursion)
                Given a string, write a method that prints it in reverse order.
                Expected input and output
                StringInReverseOrderRecursion("abcde") → "edcba"

                StringInReverseOrderRecursion("Sed lectus est, elementum ut urna eu") → "ue anru tu mutnemele ,tse sutcel deS"
             */
            string reversedString = string.Empty;

            if (text.Length == 1)
            {
                reversedString += text;
            }
            else
            {
                string temp = text.Substring(0, text.Length - 1);
                reversedString = text[text.Length - 1].ToString() + StringInReverseOrderRecursion(temp);
            }

            return reversedString;
        }

        public bool IsPalinDromeRecursive(string text)
        {
            /* Exercise text.
             * Given a string, 
               write a method that checks if it is a palindrome. String length may be >= 0.
                Expected input and output
                IsPalindromeRecursion("xx") → true

                IsPalindromeRecursion("pendrive") → false
             */

            /*
             * DEFINITION FROM WIKIPEDIA
             * 
             * A palindrome is a word, number, phrase, or other sequence of symbols that reads the same backwards as forwards
             */
            bool IsPalinDrome = false;

            if (text.Length == 1)
            {
                IsPalinDrome = true;
            }
            else if (text.Length == 2 && text[0].Equals(text[1]))
            {
                IsPalinDrome = true;

            }
            else
            {
                if (text[0].Equals(text[text.Length - 1]))
                {
                    string temp = text.Substring(1, text.Length - 2);
                    IsPalinDrome = IsPalinDromeRecursive(temp);
                }
                else
                {
                    IsPalinDrome = false;
                }

            }
            return IsPalinDrome;

        }

        public int? MinimumElement(int[] elements, int arrayLength)
        {
            /* TOOK 16 min.
             * Given an array of integers and array's length, write a method that returns its minimum element.
                Expected input and output
                 MinimumElement([8, 5, 9], 3) → 5

                 MinimumElement([-2, -9, 2, -3, 1, 0], 6) → -9
             */

            int? minimumElement = null;

            if (arrayLength == 1)
            {
                minimumElement = elements[0];
            }
            else if (arrayLength > 1)
            {
                minimumElement = MinimumElement(elements, arrayLength - 1);
                if (minimumElement == null || elements[arrayLength - 1] < minimumElement)
                {
                    minimumElement = elements[arrayLength - 1];
                }

            }

            return minimumElement;


        }

    }
}
