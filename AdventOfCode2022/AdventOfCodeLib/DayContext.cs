using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeLib
{
    public class DayContext
    {
        public DayContext(string input, string testInput1, string testInput2, string testAnswer1, string testAnswer2)
        {
            Input = input;
            TestInput1 = testInput1;
            TestInput2 = testInput2;
            TestAnswer1 = testAnswer1;
            TestAnswer2 = testAnswer2;
        }

        public string Input { get; }
        public string TestInput1 { get; }
        public string TestInput2 { get; }
        public string TestAnswer1 { get; }
        public string TestAnswer2 { get; }
    }
}
