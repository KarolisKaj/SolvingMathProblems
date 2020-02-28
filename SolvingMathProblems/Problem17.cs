using System;
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
                if (i - 100 >= 0)
                {
                    result += Problem17Helper.GetTextRepresentationOfSingleNumber(i.ToString()[0]).Length + 4;
                    if (i % 100 != 0)
                        result += 3;
                }
                if ((i % 100) - 10 >= 0)
                {
                    result += Problem17Helper.GetTextOfTenths((i % 100).ToString()[0]).Length;
                    if ((i % 10) != 0) result++;
                }
                if ((i % 10) != 0)
                {
                    result += Problem17Helper.GetTextRepresentationOfSingleNumber(i.ToString().Last()).Length;
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

        public static string GetTextOfTenths(char text)
        {
            switch (Convert.ToInt16(text.ToString()))
            {
                case 1:
                    return "Ten";
                case 2:
                    return "Twenty";
                case 3:
                    return "Thirty";
                case 4:
                    return "Forty";
                case 5:
                    return "Fifty";
                case 6:
                    return "Sixty";
                case 7:
                    return "Seventy";
                case 8:
                    return "Eighty";
                case 9:
                    return "Ninety";
                case 0:
                    return String.Empty;
                default:
                    return String.Empty;
            }
        }

    }
}