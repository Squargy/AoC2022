using CommunityToolkit.HighPerformance;
using CommunityToolkit.HighPerformance.Enumerables;
using System.Text;

namespace AdventOfCodeLib.Days;

public class Day8 : IDay
{
    class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Visible { get; set; }
        public int Height { get; init; }

        public Tree(int x, int y, int height, bool visible)
        {
            X = x;
            Y = y;
            Height = height;
            Visible = visible;
        }
    }

    private Span2D<Tree> CreateForest(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var width = lines.First().Length;
        var arr = new Tree[width, lines.Length];
        Span2D<Tree> forrest = new (arr);

        for (int y = 0; y < lines.Length; y++)
        {
            for (int x = 0; x < width; x++)
            {
                forrest[x, y] = new Tree(x, y, int.Parse(lines[y][x].ToString()), false);
            }
        }

        return forrest;
    }

    private List<Tree> ForrestToTrees(Span2D<Tree> forrest)
    {
        List<Tree> trees = new ();
        foreach (var tree in forrest)
        {
            trees.Add(tree);
        }
        return trees;
    }

    private void LookThrough(Span2D<Tree> forrest)
    {
        LookThroughFromWest(forrest);
        LookThroughFromEast(forrest);
        LookThroughFromNorth(forrest);
        LookThroughFromSouth(forrest);
    }

    private int CheckVisibility(Tree tree, int maxHeight)
    {
        tree.Visible = tree.Visible || maxHeight < tree.Height;
        return Math.Max(maxHeight, tree.Height);
    }


    private void LookThroughFromSouth(Span2D<Tree> forrest)
    {
        for (int x = 0; x < forrest.Width; x++)
        {
            int maxHeight = -1;
            for (int y = 0; y < forrest.Height; y++)
            {
                maxHeight = CheckVisibility(forrest[x, y], maxHeight);
            }
        }
    }

    private void LookThroughFromNorth(Span2D<Tree> forrest)
    {
        for (int x = 0; x < forrest.Width; x++)
        {
            int maxHeight = -1;
            for (int y = forrest.Height - 1; 0 <= y; y--)
            {
                maxHeight = CheckVisibility(forrest[x, y], maxHeight);
            }
        }
    }

    private void LookThroughFromEast(Span2D<Tree> forrest)
    {
        for (int y = 0; y < forrest.Height; y++)
        {
            int maxHeight = -1;
            for (int x = forrest.Width - 1; 0 <= x; x--)
            {
                maxHeight = CheckVisibility(forrest[x, y], maxHeight);
            }
        }
    }

    private void LookThroughFromWest(Span2D<Tree> forrest)
    {
        for (int y = 0; y < forrest.Height; y++)
        {
            int maxHeight = -1;
            for (int x = 0; x < forrest.Width; x++)
            {
                maxHeight = CheckVisibility(forrest[x, y], maxHeight);
            }
        }
    }

    public string SolveFirst(string input)
    {
        Span2D<Tree> forrest = CreateForest(input);
        LookThrough(forrest);
        return ForrestToTrees(forrest).Count(t => t.Visible)
            .ToString();
    }

    private int CalculateScenicScore(Span2D<Tree> forrest, int posX, int posY)
    {
        if (Math.Min(posX, posY) == 0 || Math.Max(posX, posY) == forrest.Width - 1)
            return 0;

        return LookWest(forrest, posX, posY) * LookEast(forrest, posX, posY) * LookNorth(forrest, posX, posY) * LookSouth(forrest, posX, posY);
    }

    private int LookEast(Span2D<Tree> forrest, int posX, int posY)
    {
        int maxHeight = forrest[posX, posY].Height;
        int count = 0;

        for (int x = posX; x < forrest.Width; x++)
        {
            if (x == posX)
                continue;

            count++;
            if (maxHeight <= forrest[x, posY].Height)
                break;
            maxHeight = Math.Max(maxHeight, forrest[x, posY].Height);
        }

        return count;
    }

    private int LookWest(Span2D<Tree> forrest, int posX, int posY)
    {
        int maxHeight = forrest[posX, posY].Height;
        int count = 0;

        for (int x = posX; 0 <= x; x--)
        {
            if (x == posX)
                continue;

            count++;
            if (maxHeight <= forrest[x, posY].Height)
                break;
            maxHeight = Math.Max(maxHeight, forrest[x, posY].Height);
        }

        return count;
    }

    private int LookSouth(Span2D<Tree> forrest, int posX, int posY)
    {
        int maxHeight = forrest[posX, posY].Height;
        int count = 0;

        for (int y = posY; y < forrest.Width; y++)
        {
            if (y == posY)
                continue;

            count++;
            if (maxHeight <= forrest[posX, y].Height)
                break;
            maxHeight = Math.Max(maxHeight, forrest[posX, y].Height);
        }

        return count;
    }

    private int LookNorth(Span2D<Tree> forrest, int posX, int posY)
    {
        int maxHeight = forrest[posX, posY].Height;
        int count = 0;

        for (int y = posY; 0 <= y; y--)
        {
            if (y == posY)
                continue;

            count++;
            if (maxHeight <= forrest[posX, y].Height)
                break;
            maxHeight = Math.Max(maxHeight, forrest[posX, y].Height);
        }

        return count;
    }

    public string SolveSecond(string input)
    {
        int maxScenicScore = 0;

        var forrest = CreateForest(input);

        foreach (var tree in forrest)
        {
            var calculated = CalculateScenicScore(forrest, tree.X, tree.Y);
            maxScenicScore = Math.Max(maxScenicScore, calculated);
        }

        return maxScenicScore.ToString();
    }
}
