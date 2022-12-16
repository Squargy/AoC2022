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

        public async static Task<(string, string)> ReadTest(int day, string part)
        {
            TestAnswerContainer answers = new();

            var inputPath = @$"C:\Users\emil\source\repos\AoC2022\AdventOfCode2022\TestInput{day}.txt";

            var input = await File.ReadAllTextAsync(inputPath);
            var answer = answers.Get(day, part);

            return (input, answer);
        }
    }
}
