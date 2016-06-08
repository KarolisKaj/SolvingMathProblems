namespace SolvingMathProblems
{
    using System.Collections.Generic;
    static internal class Problem15
    {
        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// How many such routes are there through a 20×20 grid?
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 1M;
            int n = 40;
            int k = 20;

            if (k > (n - k))
                k =- n;

            for (int i = 0; i < k; i++)
            {
                result *= (n - i);
                result /= (i + 1);
            }

            return result;
        }
    }
}