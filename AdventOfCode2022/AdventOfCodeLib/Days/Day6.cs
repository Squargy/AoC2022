using System.Text;

namespace AdventOfCodeLib.Days;

public class Day6 : Day
{
    public Day6(DayContext context) : base(context)
    {
    }

    protected override string FirstSolutionLogic(string input)
    {
        var stream = new MemoryStream(Encoding.ASCII.GetBytes(input));
        
        var buffer = new byte[4];

        stream.Read(buffer, 0, 4);

        var queue = new Queue<byte>(buffer);

        int next = 0;

        do
        {
            if (queue.ToHashSet<byte>().Count == 4)
            {
                return stream.Position.ToString();
            }

            queue.Dequeue();
            next = stream.ReadByte();
            queue.Enqueue((byte)next);
        } while (next != -1);

        throw new IndexOutOfRangeException();
    }

    protected override string SecondSolutionLogic(string input)
    {
        throw new NotImplementedException();
    }
}
