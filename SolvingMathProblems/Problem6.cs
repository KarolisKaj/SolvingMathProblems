using System;

namespace SolvingMathProblems
{
    static internal class Problem6
    {
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 12 + 22 + ... + 102 = 385
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)2 = 552 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;

            Int64 smallerSequence = 0;
            Int64 greaterSequence = 0;

            for (int i = 1; i < 101; i++)
            {
                smallerSequence += i * i;
                greaterSequence += i;
            }
            greaterSequence *= greaterSequence;

            result = greaterSequence - smallerSequence;
            return result;
        }
    }
}