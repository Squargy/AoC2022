Console.WriteLine("Running Advent of Code Driver...");
Console.WriteLine();

int dayNumber = 7; 

var day = DayFactory.Create(dayNumber);

try
{
    Console.WriteLine("Answer: " + day.SolveFirst(await PuzzleInputReader.Read(dayNumber)));
}
catch (Exception ex)
{
    Console.WriteLine("First solution threw exception: " + ex);
}
Console.WriteLine();
try
{
    Console.WriteLine("Answer: " + day.SolveSecond(await PuzzleInputReader.Read(dayNumber)));
}
catch (Exception ex)
{
    Console.WriteLine("Second solution threw exception: " + ex);
}


Console.WriteLine("Exiting Advent of Code Driver!");