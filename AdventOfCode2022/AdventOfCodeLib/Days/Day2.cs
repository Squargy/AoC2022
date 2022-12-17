namespace AdventOfCodeLib.Days;

public class Day2 : Day
{
    private readonly Dictionary<string, string> BeatMap = new()
    {
        { "B", "A" },
        { "C", "B" },
        { "A", "C" },
    };

    private string MapToABC1(string xyz) 
    {
        switch (xyz)
        {
            case "X": return "A";
            case "Y": return "B";
            case "Z": return "C";
            default:
                throw new ArgumentException();
        }
    }

    private string MapToABC2(string xyz, string opponent)
    {
        switch (xyz)
        {
            case "X": return BeatMap[opponent];
            case "Y": return opponent;
            case "Z": return BeatMap.Single(v => v.Value == opponent).Key;
            default:
                throw new ArgumentException();
        }
    }

    private int ResolveRound(string opponent, string me)
    {
        bool? win = null;

        if (BeatMap[me] == opponent)
            win = true;
        else if (BeatMap[opponent] == me) 
            win = false;

        return SumScore(me, win);
    }

    private int SumScore(string me, bool? win)
    {
        int score = me switch
        {
            "A" => 1,
            "B" => 2,
            "C" => 3,
            _ => throw new NotImplementedException()
        };

        if (!win.HasValue)
            score += 3;
        else if (win.Value)
            score += 6;

        return score;
    }

    public override string SolveFirst(string input)
    {
        int totalScore = 0;

        foreach (var item in input.Split(Environment.NewLine))
        {
            var moves = item.Split(' ');
            totalScore += ResolveRound(moves.First(), MapToABC1(moves.Last()));
        }

        return totalScore.ToString();
    }

    public override string SolveSecond(string input)
    {
        int totalScore = 0;

        foreach (var item in input.Split(Environment.NewLine))
        {
            var moves = item.Split(' ');
            totalScore += ResolveRound(moves.First(), MapToABC2(moves.Last(), moves.First()));
        }

        return totalScore.ToString();
    }
}