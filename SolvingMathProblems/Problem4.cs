namespace SolvingMathProblems
{
    using System;
    using System.Linq;
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    ///Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    static internal class Problem4
    {
        public static decimal Answer()
        {
            decimal result = 0M;
            decimal tempResult = 0M;
            decimal firstNumber = 999M;
            decimal secondNumber = 999M;



            string temp = string.Empty;

            for (int i = 999; i > 0; i--)
            {
                firstNumber = i;
                for (int j = 999; j > 0; j--)
                {
                    secondNumber = j;
                    tempResult = firstNumber * j;

                    if (IsPolindron(tempResult.ToString()) && result < tempResult)
                    {
                        result = tempResult;
                    }
                }
            }

            return result;
        }

        static bool IsPolindron(string temp)
        {
            if (temp.Length % 2 == 1)
            {
                temp.Remove((int)Math.Round(temp.Length / 2d), 1);
            }

            int half = temp.Length / 2;
            string S2 = temp.Substring(0, half);
            string S3 = temp.Substring(half, half);

            return S2.Equals(String.Join("", S3.Reverse().ToArray()));

        }
    }
}