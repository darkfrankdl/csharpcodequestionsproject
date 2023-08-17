using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisesFirstTry.Exercise
{
    internal class BasicsExercises
    {

        public double AddTwoNumbersThenMultiplyByOneNumber(double num1, double num2, double num3)
        {
            /* Exercise Text:
             * Given three numbers, write a method that adds two first ones and multiplies them by a third one.
                Expected input and output
                AddAndMultiply(2, 4, 5) → 30
             */

            return (num1 + num2) * num3;
        }

        public string CelsiusToFehrenheit(double celsius)
        {
            /* Exercise text:
             * Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!
                Expected input and output
                CtoF(0) → "T = 32F"

                CtoF(100) → "T = 212F"

                CtoF(-300) → "Temperature below absolute zero!"
             */

            string textToReturn = "";

            // formalia: F = (C * 1,8) +32 or (C * 9/5)+32
            if (celsius <= -271.15)
            {
                textToReturn = "Temperature below absolute zero";
            }
            else
            {
                double fehrenheit = celsius * 1.8 + 32;
                textToReturn = "the temperature is : " + fehrenheit.ToString() + "F";
            }

            return textToReturn;
        }

        public void ElementaryOperations(double x, double y)
        {
            /* Exercise text:
             * Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!
                Expected input and output
                ElementaryOperations(3, 8) → 11, -5, 24, 0.375
            */
            double add = x + y;
            double sub = x - y;
            double mul = x * y;

            Console.WriteLine("add = " + add);
            Console.WriteLine("sub = " + sub);
            Console.WriteLine("mul = " + mul);
            if (y == 0)
            {
                Console.WriteLine("Can't diviate with 0");
            }
            else
            {
                double div = x / y;
                Console.WriteLine("div = " + div);
            }
        }

        public bool IsResultTheSame(string operation1, string operation2)
        {
            /* Exercise text:
             * Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
                Expected input and output
                IsResultTheSame(2+2, 2*2) → true

                IsResultTheSame(9/3, 16-1) → false
            */

            int? cal1 = IsResultTheSameCalculator(operation1);
            int? cal2 = IsResultTheSameCalculator(operation2);

            return ComperatorTheSame(cal1, cal2);

        }


        private int? IsResultTheSameCalculator(string calOperation)
        {
            int? ToReturn = null;
            int indexOperator = findOperatorIndex(calOperation);
            string operationleftSideOfOperator = calOperation.Substring(0, calOperation.Length - (calOperation.Length - indexOperator));
            string operationrightSideOfOperator = calOperation.Substring(indexOperator + 1);

            int leftSide = int.Parse(operationleftSideOfOperator);
            int rightSide = int.Parse(operationrightSideOfOperator);



            if (calOperation.ToArray()[indexOperator].Equals('+'))
            {
                ToReturn = leftSide + rightSide;
            }

            if (calOperation.ToArray()[indexOperator].Equals('/'))
            {
                if (rightSide != 0)
                {
                    ToReturn = leftSide / rightSide;
                }
                else
                {
                    try
                    {
                        ToReturn = leftSide / rightSide;
                    }
                    catch (Exception ex)
                    { Console.WriteLine("Can't deviate with 0"); }
                }
            }

            if (calOperation.ToArray()[indexOperator].Equals('*'))
            {
                ToReturn = leftSide * rightSide;
            }

            if (calOperation.ToArray()[indexOperator].Equals('-'))
            {
                ToReturn = leftSide - rightSide;
            }

            return ToReturn;
        }

        private bool ComperatorTheSame(int? calculation1, int? calculation2)
        {
            bool ToReturn = false;
            if (calculation1 == calculation2)
            {
                ToReturn = true;
            }


            return ToReturn;
        }

        private int findOperatorIndex(string operation1)
        {
            bool goon = true;
            int operation2OperatorPlacement = -1;

            char[] operation2CharArray = operation1.ToArray();

            for (int i = 0; i < operation2CharArray.Length && goon; i++)
            {
                if (i == 0 && operation2CharArray[0] == '-')
                {
                }
                else
                {
                    if (operation2CharArray[i].Equals('+'))
                    {
                        operation2OperatorPlacement = i;
                        goon = false;
                    }

                    if (operation2CharArray[i].Equals('/'))
                    {
                        operation2OperatorPlacement = i;
                        goon = false;
                    }

                    if (operation2CharArray[i].Equals('*'))
                    {

                        operation2OperatorPlacement = i;
                        goon = false;
                    }

                    if (operation2CharArray[i].Equals('-'))
                    {
                        operation2OperatorPlacement = i;
                        goon = false;
                    }
                }

            }

            return operation2OperatorPlacement;
        }

        public int? ModuloOperations(int first, int second, int third)
        {
            /* Exercise text:
             * Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
                Expected input and output
                ModuloOperations(8, 5, 2) → 1
             */
            int? toReturn = null;
            int? subResult = null;

            try
            {
                subResult = first % second;
                toReturn = subResult % third;
                Console.WriteLine("Expected 1 -> actual : " + toReturn);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't diviate with 0");
            }

            return toReturn;
        }

        public double TheCubeOf(double x)
        {
            /*
             * Given a number, write a method that returns its cube.
                Expected input and output
                TheCubeOf(2) → 8

                TheCubeOf(-5.5) → -166.375
             */

            // cube is x*x*x
            return x * x * x;
        }

        public (int, int) SwapTwoNumber(int x, int y)
        {
            /*
             * Given two integers, write a method that swaps them using temporary variable.
                Expected input and output
                SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"

                SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"
             */

            int temp = x;
            x = y;
            y = temp;

            return (x, y);
        }
    }
}
