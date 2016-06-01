namespace SolvingMathProblems
{
    using ExtractData;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    static internal class Problem11
    {
        /// <summary>
        /// In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
        /// The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
        /// What is the greatest product of four adjacent numbers in the same direction(up, down, left, right, or diagonally) in the 20×20 grid?
        /// <returns></returns>

        private static string _numbersSequence = FileReader.ReadData("Problem11Data.txt");
        public static decimal Answer()
        {
            decimal result = 0M;
            decimal tempResult = 0M;
            var grid = GetGrid();

            //  Horizontal line.
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    tempResult = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                    if (tempResult > result)
                        result = tempResult;
                }
            }

            // Verical line.
            for (int j = 0; j < 17; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    tempResult = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                    if (tempResult > result)
                        result = tempResult;
                }
            }

            // Diagonal.
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // \ up.
                    if (i - 3 < 20 && i - 3 > -1 && j - 3 < 20 && j - 3 > -1)
                    {
                        tempResult = grid[i, j] * grid[i - 1, j - 1] * grid[i - 2, j - 2] * grid[i - 3, j - 3];
                        if (tempResult > result)
                            result = tempResult;
                    }
                    // / up.
                    if (i + 3 < 20 && i + 3 > -1 && j - 3 < 20 && j - 3 > -1)
                    {
                        tempResult = grid[i, j] * grid[i + 1, j - 1] * grid[i + 2, j - 2] * grid[i + 3, j - 3];

                        if (tempResult > result)
                            result = tempResult;
                    }

                    // \ down.
                    if (i + 3 < 20 && i + 3 > -1 && j + 3 < 20 && j + 3 > -1)
                    {
                        tempResult = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];

                        if (tempResult > result)
                            result = tempResult;
                    }

                    // / down.
                    if (i - 3 < 20 && i - 3 > -1 && j + 3 < 20 && j + 3 > -1)
                    {
                        tempResult = grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3];

                        if (tempResult > result)
                            result = tempResult;
                    }

                }
            }

            return result;
        }

        private static ulong[,] GetGrid()
        {
            var rows = _numbersSequence.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            ulong[,] grid = new ulong[20, 20];

            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    grid[j, i] = Convert.ToUInt64(rows[j].Split(new string[] { " " }, StringSplitOptions.None)[i]);
                }
            }

            return grid;
        }
    }
}