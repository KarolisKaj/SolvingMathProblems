using System;
using System.IO;
using System.Reflection;

namespace SolvingMathProblems.ExtractData
{
    public class FileReader
    {
        public static string ReadData(string fileName)
        {
            string currentDir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "ProblemData", fileName);

            var contentText = File.ReadAllText(currentDir);

            return contentText;
        }
    }
}
