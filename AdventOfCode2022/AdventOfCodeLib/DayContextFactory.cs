using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeLib
{
    public static class DayContextFactory
    {
        public static async Task<DayContext> Create(int dayNumber)
        {
            var input = await PuzzleInputReader.Read(dayNumber);
            (var testInput1, var answer1) = await PuzzleInputReader.ReadTest(dayNumber, "a");
            (var testInput2, var answer2) = await PuzzleInputReader.ReadTest(dayNumber, "b");

            return new DayContext(input, testInput1, testInput2, answer1, answer2);
        }
    }
}
