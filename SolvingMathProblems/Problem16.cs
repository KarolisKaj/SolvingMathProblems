using System;

namespace SolvingMathProblems
{
    static internal class Problem17
    {
        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        /// How many such routes are there through a 20×20 grid?
        /// <returns></returns>
        public static decimal Answer()
        {
            decimal result = 0M;

            return result;
        }

    }

    public static class Problem17Helper
    {
        public string GetConvertedValue(decimal number)
        {
            var numberAsString = number.ToString();

            return numberAsString.GetTextRepresentation();
        }

        public string GetTextRepresentation(this string text)
        {
            switch (text.Length)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public static string GetTextRepresentationOfSingleNumber(string text)
        {
            switch (Convert.ToInt16(text))
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
            switch (Convert.ToInt16(text))
            {
                case 1:
                    return text.GetFirstTenAndTweny();
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

        private static string GetFirstTenAndTweny(this string text)
        {
            switch(text.)

        }
    }
}