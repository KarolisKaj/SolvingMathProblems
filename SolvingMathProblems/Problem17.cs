using System;
using System.Collections.Generic;
using System.Linq;

namespace SolvingMathProblems
{
    static internal class Problem17
    {
        /// <summary>
        /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
        /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
        /// <returns></returns>
        public static decimal Answer()
        {
            var sut = 1000;
            var result = 0;
            for (int i = 1; i <= sut; i++)
            {
                if (i % 1000 == 0)
                {
                    result += "onethousand".Length;
                }
                else if (i - 100 >= 0)
                {
                    result += Problem17Helper.GetTextRepresentationOfSingleNumber(i.ToString()[0]).Length + 7;
                    if (i % 100 != 0)
                        result += 3;
                }
                if ((i % 100) != 0)
                {
                    result += Problem17Helper.GetTextOfTenths((i % 100).ToString()).Length;
                }
            }
            return result;
        }

    }

    public static class Problem17Helper
    {
        public static string GetTextRepresentationOfSingleNumber(char text)
        {
            switch (Convert.ToInt16(text.ToString()))
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return String.Empty;
                default:
                    return String.Empty;
            }
        }

        public static string GetTextOfTenths(string text)
        {
            var number = Convert.ToInt16(text.ToString());
            if (number < 10) return GetTextRepresentationOfSingleNumber(text[0]);
            if (number > 9 && number < 20) return GetTenToNineteen(text);
            var lastNumber = string.Empty;
            if (number % 10 != 0) lastNumber = GetTextRepresentationOfSingleNumber((number % 10).ToString()[0]);
            switch (number - (number % 10))
            {
                case 10:
                    return "Ten";
                case 20:
                    return lastNumber + "Twenty";
                case 30:
                    return lastNumber + "Thirty";
                case 40:
                    return lastNumber + "Forty";
                case 50:
                    return lastNumber + "Fifty";
                case 60:
                    return lastNumber + "Sixty";
                case 70:
                    return lastNumber + "Seventy";
                case 80:
                    return lastNumber + "Eighty";
                case 90:
                    return lastNumber + "Ninety";
                default:
                    return String.Empty;
            }
        }
        public static string GetTenToNineteen(string text)
        {
            switch (Convert.ToInt16(text.ToString()))
            {
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                default:
                    return String.Empty;
            }
        }
    }
}