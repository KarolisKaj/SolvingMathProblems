namespace SolvingMathProblems
{
    using System;
    using System.Linq;
    static internal class Problem7
    {
        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10 001st prime number?
        /// <returns></returns>
        public static decimal Answer()
        {

            decimal result = 0M;
            bool[] valueArr = Enumerable.Repeat(true, 2000000).ToArray();
            int value;
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
            var index = 0;
            var count = 0;
            foreach (var item in valueArr)
            {
                if (item)
                    count++;
                if (count == 10003) // Declude first 2, since it is 1 and 2.
                    return index;

                index++;
            }
            //result = Array.FindIndex(valueArr, _ => valueArr.Count(x => x) == 6);
            result = index;
            return result;
        }
    }
}