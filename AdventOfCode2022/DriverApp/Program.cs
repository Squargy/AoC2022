Console.WriteLine("Running Advent of Code Driver...");
Console.WriteLine();

int dayNumber = 6; 

var day = DayFactory.Create(dayNumber, DayContextFactory.Create(dayNumber).Result);

try
{
    Console.WriteLine("Answer: " + day.SolveFirst());
}
catch (Exception ex)
{
    Console.WriteLine("First solution threw exception: " + ex);
}
Console.WriteLine();
try
{
    Console.WriteLine("Answer: " + day.SolveSecond());
}
catch (Exception ex)
{
    Console.WriteLine("Second solution threw exception: " + ex);
}


Console.WriteLine("Exiting Advent of Code Driver!");