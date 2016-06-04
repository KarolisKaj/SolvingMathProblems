namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Numerics;
    static internal class Problem13
    {
        /// <summary>
        /// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
        /// <returns></returns>

        private static string _numbersSequence = FileReader.ReadData("Problem13Data.txt");
        public static string Answer()
        {
            string[] numbers = GetData();
            BigInteger result = new BigInteger();
            for (int i = 0; i < numbers.Length; i++)
            {
                result += BigInteger.Parse(numbers[i]);
            }

            return result.ToString();
        }

        private static string[] GetData()
        {
            return _numbersSequence.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }
}