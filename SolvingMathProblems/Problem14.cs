namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Numerics;
    static internal class Problem14
    {
        /// <summary>
        /// The following iterative sequence is defined for the set of positive integers:
        /// n → n/2 (n is even)
        /// n → 3n + 1 (n is odd)
        /// Using the rule above and starting with 13, we generate the following sequence:
        /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        /// Which starting number, under one million, produces the longest chain?
        /// NOTE: Once the chain starts the terms are allowed to go above one million.
        /// <returns></returns>

        private static Dictionary<long, int> _countedValues = new Dictionary<long, int>();
        public static decimal Answer()
        {
            decimal result = 0M;
            int highestChain = 0;
            for (int i = 13; i < 1000000; i++)
            {
                GetChainCount(i);
            }
            foreach (var item in _countedValues)
            {
                if (item.Value > highestChain)
                {
                    highestChain = item.Value;
                    result = item.Key;
                }
            }

            return result;
        }

        // Moved away from recursion due to StackOverflow which is caused by Tail-Recursion (wiki it up) :)
        private static void GetChainCount(long number)
        {
            if (_countedValues.ContainsKey(number))
                return;

            long originalNumber = number;
            int tempCounter = 0;
            do
            {
                if (_countedValues.ContainsKey(number))
                {
                    _countedValues.Add(originalNumber, tempCounter + _countedValues[number]);
                    return;
                }

                if (number % 2 == 0)
                {
                    number /= 2;
                    tempCounter++;
                }
                else
                {
                    number = 3 * number + 1;
                    tempCounter++;
                }
            }
            while (number > 1);

            tempCounter++;
            _countedValues.Add(originalNumber, tempCounter);


        }
    }
}