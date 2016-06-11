namespace SolvingMathProblems
{
    using System;
    using System.Linq;
    using System.Numerics;
    static internal class Problem16
    {
        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// How many such routes are there through a 20×20 grid?
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;

            var resultInString = BigInteger.Pow(2, 1000).ToString();

            for (int i = 0; i < resultInString.Length; i++)
            {
                result += (decimal)Char.GetNumericValue(resultInString[i]);
            }

            return result;
        }
    }
}