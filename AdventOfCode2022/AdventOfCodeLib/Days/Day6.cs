using System.Text;

namespace AdventOfCodeLib.Days;

public class Day6 : Day
{
    public override string SolveFirst(string input)
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

    public override string SolveSecond(string input)
    {
        var stream = new MemoryStream(Encoding.ASCII.GetBytes(input));

        var buffer = new byte[14];

        stream.Read(buffer, 0, 14);

        var queue = new Queue<byte>(buffer);

        int next = 0;

        do
        {
            if (queue.ToHashSet<byte>().Count == 14)
            {
                return stream.Position.ToString();
            }

            queue.Dequeue();
            next = stream.ReadByte();
            queue.Enqueue((byte)next);
        } while (next != -1);

        throw new IndexOutOfRangeException();
    }
}
