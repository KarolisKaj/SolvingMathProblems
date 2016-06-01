namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    static internal class Problem8
    {
        /// <summary>
        /// The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// <returns></returns>
        private static string _numbersSequence = FileReader.ReadData("Problem8Data.txt");
        public static decimal Answer()
        {
            decimal result = 0M;

            char[] chars = _numbersSequence.Replace(Environment.NewLine, String.Empty).ToCharArray();
            List<ulong> results = new List<ulong>();

            for (int i = 12; i < chars.Length; i++)
            {
                results.Add(
                    (ulong)Char.GetNumericValue(chars[i - 12]) *
                    (ulong)Char.GetNumericValue(chars[i - 11]) *
                    (ulong)Char.GetNumericValue(chars[i - 10]) *
                    (ulong)Char.GetNumericValue(chars[i - 9]) *
                    (ulong)Char.GetNumericValue(chars[i - 8]) *
                    (ulong)Char.GetNumericValue(chars[i - 7]) *
                    (ulong)Char.GetNumericValue(chars[i - 6]) *
                    (ulong)Char.GetNumericValue(chars[i - 5]) *
                    (ulong)Char.GetNumericValue(chars[i - 4]) *
                    (ulong)Char.GetNumericValue(chars[i - 3]) *
                    (ulong)Char.GetNumericValue(chars[i - 2]) * 
                    (ulong)Char.GetNumericValue(chars[i - 1]) * 
                    (ulong)Char.GetNumericValue(chars[i]));
            }

            results = results.OrderBy(x => x).Reverse().ToList();

            result = results[0];

            return result;
        }
    }
}