namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    static internal class Problem10
    {
        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;
            var primalNumbers = AlteredNo7();

            for (int i = 2; i < primalNumbers.Length; i++)
            {
                if (primalNumbers[i])
                    result += i;
            }
            return result;
        }

        public static bool[] AlteredNo7()
        {

            decimal result = 0M;
            int value = 0;
            bool[] valueArr = Enumerable.Repeat(true, 2000000).ToArray();

            for (int i = 2; i < valueArr.Length; i++)
            {
                result = 0;
                for (int j = 0; j < valueArr.Length; j++)
                {
                    value = (int)Math.Pow(i, 2) + j * i;
                    if (value < valueArr.Length && value > 0)
                        valueArr[(int)Math.Pow(i, 2) + j * i] = false;
                    else
                        break;
                }
            }
            //result = Array.FindIndex(valueArr, _ => valueArr.Count(x => x) == 6);
            return valueArr;
        }
    }
}