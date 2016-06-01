namespace SolvingMathProblems
{
    static internal class Problem5
    {
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;

            decimal tempResult = 0M;

            while (true)
            {
                tempResult++;
                for (int i = 20; i > 0; i--)
                {
                    if (tempResult % i != 0)
                        break;
                    if (i == 1)
                        result = tempResult;
                }

                if (result == tempResult)
                    break;
            }

            return result;
        }
    }
}