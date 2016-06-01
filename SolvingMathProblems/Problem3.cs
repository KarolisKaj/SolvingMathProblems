using System.Collections.Generic;
using System.Linq;

namespace SolvingMathProblems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    static internal class Problem3
    {
        public static decimal Answer()
        {
            decimal result = 1M;
            decimal givenValue = 600851475143;
            List<decimal> blah = new List<decimal>();
            decimal devisionNo;

            while (true)
            {
                devisionNo = 2;
                while (true)
                {
                    if (givenValue % devisionNo == 0)
                    {
                        blah.Add(devisionNo);
                        givenValue = givenValue / devisionNo;
                        break;
                    }
                    devisionNo++;
                }
                if (givenValue == 1)
                    break;
            }

            foreach (var item in blah)
            {
                result *= item;
            }
            return result;
        }
    }
}
