namespace CSharpExercisesFirstTry.Exercise
{
    internal class ConditionalStatementsExercises
    {
        public int? AbsoluteValue(int? value)
        {
            /* Exercise Text:
             * Given an integer, write a method that returns its absolute value.
                Expected input and output
                AbsoluteValue(6832) → 6832

                AbsoluteValue(-392) → 392
             */

            int? numberToReturn = null;
            if (value < 0)
            {
                numberToReturn = value * -1;
            }
            else
            {
                numberToReturn = value;
            }


            return numberToReturn;
        }

        public int? DivisibleBy2or3(int? number1, int? number2)
        {
            // Exercise text:
            //Given two integers, write a method that returns their
            //multiplication if they are both divisible by 2 or 3,
            //otherwise returns thier sum.

            int? numberToReturn = null;
            // find out if divisible by 2
            bool isDivisibleBy3or2Number1 = false;
            bool isDivisibleBy3or2Number2 = false;
            if (number1 % 2 == 0 && number2 % 2 == 0)
            {
                isDivisibleBy3or2Number2 = true;
                isDivisibleBy3or2Number1 = true;
            }
            // find out if divisible by 3
            else if (number1 % 3 == 0 && number2 % 3 == 0)
            {
                isDivisibleBy3or2Number2 = true;
                isDivisibleBy3or2Number1 = true;
            }

            else if (number1 % 2 == 0 && number2 % 3 == 0)
            {
                isDivisibleBy3or2Number2 = true;
                isDivisibleBy3or2Number1 = true;
            }

            else if (number1 % 3 == 0 && number2 % 2 == 0)
            {
                isDivisibleBy3or2Number2 = true;
                isDivisibleBy3or2Number1 = true;
            }

            // if divisible by 2 or 3 multiple else sum
            if (isDivisibleBy3or2Number2 && isDivisibleBy3or2Number1)
            {
                numberToReturn = number1 * number2;
            }
            else
            {
                numberToReturn = number1 + number2;
            }

            return numberToReturn;
        }

        public bool IfConsistsOfUppercaseLetters(string threeCharacterString)
        {
            /* Exercise Text:
             * Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
                Expected input and output
                IfConsistsOfUppercaseLetters("xyz") → false

                IfConsistsOfUppercaseLetters("DOG") → true

                IfConsistsOfUppercaseLetters("L9#") → false
            */

            bool isOnlyUpperCase = false;

            char[] threeCharacterStringArray = threeCharacterString.ToCharArray();

            var result = threeCharacterStringArray.All((character) =>
            {
                bool sucessUpperCase = false;

                if (character < 'Z' && character >= 'A')
                {
                    sucessUpperCase = true;
                }
                return sucessUpperCase;
            });

            if (result)
            {
                isOnlyUpperCase = true;
            }

            return isOnlyUpperCase;
        }

        public bool IfGreaterThanThirdOne(int[] integers)
        {
            /* Exercise text:
             * Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
                Expected input and output
                IfGreaterThanThirdOne([2, 7, 12]) → true

                IfGreaterThanThirdOne([-5, -8, 50]) → false
            */


            bool isGreater = false;

            int thirdNumber = integers[integers.Length - 1];

            int multiplicationResult = integers[0] * integers[1];
            int sumResult = integers[0] + integers[1];

            isGreater = multiplicationResult > thirdNumber || sumResult > thirdNumber ? true : false;

            return isGreater;
        }

        public bool IfNumberIsEven(int numberToCheck)
        {
            // Exercise text:
            // given a integer , write a method that checks if it is even

            // input : 721 output : false
            // input : 1248 output : true

            bool isNumberEven = false;

            int check = numberToCheck % 2;

            if (check == 0)
            {
                isNumberEven = true;
            }

            return isNumberEven;
        }

        public bool ifSortedAscending(int[] integers)
        {
            // Exercise text:
            //Given an array of three integers,
            //write a method that checks if
            //they are sorted in ascending order.

            //Expected input and output
            //IfSortedAscending([3, 7, 10])→ true

            //IfSortedAscending([74, 62, 99])→ false

            bool isArrayInAscendingOrder = false;
            bool goon = true;
            for (int i = 0; i < integers.Length - 1 && goon; i++)
            {
                int numberOne = integers[i];
                int numberTwo = integers[i + 1];

                if (numberTwo > numberOne)
                {
                    isArrayInAscendingOrder = true;
                }
                else
                {
                    isArrayInAscendingOrder = false;
                    goon = false;
                }
            }

            return isArrayInAscendingOrder;
        }

        public bool IfHasNeighbour(string threeLetterString)
        {
            // Exercise text:
            // Given three letter long string, write a method that
            // checks if at least one neighbour of middle letter
            // is its neighbour in the alphabet. 

            // expected input and output 
            // IfHasNeighbour(XYZ) -> TRUE
            // IfHasNeighbour(GWK) -> FALSE

            // there is 4 cases because a neighbor does not have to be in alphabetical order thus DCB should return true.
            // as D and B is neigbors to C but not in alphabetical order.

            bool resultToReturn = false;
            bool isLeftANeighbor = false;
            bool isRightANeighbor = false;

            char[] chars = threeLetterString.ToCharArray();

            char middleLetter = chars[1];

            // checks if left is a neighbor of the middle letter
            if (chars[0] == middleLetter - 1)
            {
                isLeftANeighbor = true;
            }
            else if (chars[0] == middleLetter + 1)
            {
                isLeftANeighbor = true;
            }
            // checks if the right is a neighbor of the middle letter
            else if (chars[2] == middleLetter + 1)
            {
                isRightANeighbor = true;
            }

            else if (chars[2] == middleLetter - 1)
            {
                isRightANeighbor = true;
            }
            // checks if at least one alphabet neighbor is present.
            if (isLeftANeighbor || isRightANeighbor)
            {
                resultToReturn = true;
            }

            return resultToReturn;

        }

        public string PositiveNegativeOrZero(double number)
        {
            // Exercise text:
            // given a number , write a method that checks if it is 
            // positive , negative or zero. 

            //input -> output

            //PositiveNegativeOrZero(5.24) → positive

            //PositiveNegativeOrZero(0.0) → zero

            //PositiveNegativeOrZero(-994.53) → negative

            string resultToReturn = "";

            if (number < 0)
            {
                resultToReturn = "negative";
            }
            else if (number == 0)
            {
                resultToReturn = "zero";
            }
            else if (number > 0)
            {
                resultToReturn = "positive";
            }

            return resultToReturn;

        }

        public bool IfYearIsLeap(double year)
        {
            // Exercise text: 
            // given a year as integer, write a method that checks if year is leap
            // input -> output
            // IfYearIsLeap(2016) → true
            // IfYearIsLeap(2018) → false

            // research:
            // a leap year is divisiable by 4 , not by 100 or divisiable by 4, 100 and 400

            // implementation of theory: 

            bool isLeapYear = false;

            double theoryNumber4 = year / 4;
            double theoryNumber100 = year / 100;
            double theoryNumber400 = year / 400;
            double checkIfYearIsWholeNumberAfterDivisionWith4 = theoryNumber4 % 1;
            double checkIfYearIsWholeNumberAfterDivisionWith100 = theoryNumber100 % 1;
            double checkIfYearIsWholeNumberAfterDivisionWith400 = theoryNumber400 % 1;

            if (checkIfYearIsWholeNumberAfterDivisionWith4 == 0)
            {
                if (checkIfYearIsWholeNumberAfterDivisionWith100 != 0)
                {
                    isLeapYear = true;
                }
            }
            if (checkIfYearIsWholeNumberAfterDivisionWith4 == 0 && checkIfYearIsWholeNumberAfterDivisionWith100 == 0 && checkIfYearIsWholeNumberAfterDivisionWith400 == 0)
            {
                isLeapYear = true;
            }

            return isLeapYear;
        }

        public bool IfNumberContains3(int number)
        {
            /* Exercise text:
             * Write a method that checks if given number 
             * (positive integer) contains digit 3. 
             * Do not convert number to other type. 
             * Do not use built-in functions like Contains(), StartsWith(), etc.
             * 
             *  Expected input and output
                IfNumberContains3(7201432) → true
                IfNumberContains3(87501) → false
             * 
             */
            bool resultToReturn = false;
            // numbers that include a 3 
            /*
             * 3
             * 13
             * 23
             * 30-39
             * 43
             * 53
             * 63
             * 73
             * 83
             * 93
             * 103
             * 113
             * 123
             * 130-139
             */
            bool goon = true;
            while (number > 0 && goon)
            {
                int calculationModulo = number % 10;
                if (calculationModulo == 3)
                {
                    resultToReturn = true;
                    goon = false;
                }
                else
                {
                    number = number / 10;
                }
            }

            return resultToReturn;
        }
    }
}
