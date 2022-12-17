using System.Net;

namespace AdventOfCodeLib
{
    public static class PuzzleInputReader
    {
        public static Task<string> Read(int day)
        {
            var inputPath = @$"C:\Users\emil\source\repos\AoC2022\AdventOfCode2022\PuzzleInput{day}.txt";

            return File.ReadAllTextAsync(inputPath);
        }
    }
}
