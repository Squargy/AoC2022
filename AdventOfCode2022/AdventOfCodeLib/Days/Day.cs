namespace AdventOfCodeLib.Days
{
    public abstract class Day
    {
        private DayContext _context;

        public Day(DayContext context)
        {
            _context = context;
        }

        private bool Test(Func<string, string> logic, string input, string answer)
        {
            var ans = logic(input);

            Console.WriteLine($"Testing case resulted in {ans}.");

            return ans.Equals(answer);
        }

        private bool TestFirstCase()
        {
            return Test(FirstSolutionLogic, _context.TestInput1, _context.TestAnswer1);
        }

        private bool TestSecondCase()
        {
            return Test(SecondSolutionLogic, _context.TestInput2, _context.TestAnswer2);
        }

        protected abstract string FirstSolutionLogic(string input);

        protected abstract string SecondSolutionLogic(string input);

        private string Solve(Func<bool> solveTestCase, Func<string, string> logic)
        {
            if (!solveTestCase())
                throw new Exception($"Logic doesn't result in {_context.TestAnswer1}.");

            Console.WriteLine("Test case succeded!");

            return logic(_context.Input);
        }

        public string SolveFirst()
        {
            return Solve(TestFirstCase, FirstSolutionLogic);
        }

        public string SolveSecond()
        {
            return Solve(TestSecondCase, SecondSolutionLogic);
        }
    }
}
