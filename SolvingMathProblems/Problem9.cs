namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    static internal class Problem9
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        /// a2 + b2 = c2
        /// For example, 32 + 42 = 9 + 16 = 25 = 52.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;
            decimal a = 0M;
            decimal b = 0M;
            decimal c = 0M;

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int y = 0; y < 1000; y++)
                    {
                        if (Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(y, 2) && i + j + y == 1000)
                        {
                            a = i;
                            b = j;
                            c = y;
                            break;
                        }
                    }
                    if (a != 0)
                        break;
                }
                if (a != 0)
                    break;
            }

            result = a * b * c;

            return result;
        }
    }
}