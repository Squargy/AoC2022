using System.Collections;

namespace AdventOfCodeLib.Tests.TestData;

public class Day6SecondStarTestData : IEnumerable<(string, string)>
{
    public IEnumerator<(string, string)> GetEnumerator()
    {
        yield return ("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "19" );
        yield return ("bvwbjplbgvbhsrlpgdmjqwftvncz", "23" );
        yield return ("nppdvjthqldpwncqszvftbrmjlhg", "23" );
        yield return ("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "29" );
        yield return ("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "26" );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
