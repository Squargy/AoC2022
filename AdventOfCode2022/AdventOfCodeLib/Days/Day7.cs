namespace AdventOfCodeLib.Days;

public class Day7 : Day
{
    class PuzzleDirectory
    {
        public string Name { get; init; }
        public Dictionary<string, PuzzleDirectory> Children { get; } = new ();
        public PuzzleDirectory? Parent { get; init; }
        public long ContentLength { get; set; } = 0;

        public PuzzleDirectory(string name, PuzzleDirectory? parent)
        {
            Parent = parent;
            if (parent == null)
                Name = name;
            else
                Name = parent.BuildName(name);
        }

        private string BuildName(string name)
        {
            var childName = string.Join("/", Name, name);
            if (Parent != null)
                return Parent.BuildName(childName);
            else
                return childName;
        }

        public void AddChild(string relativeName, PuzzleDirectory child)
        {
            if (!Children.ContainsKey(relativeName))
                Children.Add(relativeName, child);
        }

        public void AddContentLength(long contentLength)
        {
            ContentLength += contentLength;
            if (Parent != null)
                Parent.AddContentLength(contentLength);
        }

        internal PuzzleDirectory GotoChild(string arg)
        {
            return Children[arg];
        }
    }

    private Dictionary<string, PuzzleDirectory> CreateDictionaries(string input)
    {
        PuzzleDirectory activeDir = new("/", null);
        Dictionary<string, PuzzleDirectory> directories = new() { { activeDir.Name, activeDir } };

        foreach (var item in input.Split(Environment.NewLine).Skip(1))
        {
            if (item == "$ ls")
                continue;
            else if (item.StartsWith("dir"))
            {
                var name = item.Split(' ').Last();
                PuzzleDirectory dir = new(name, activeDir);
                activeDir.AddChild(name, dir);
                directories[dir.Name] = dir;
            }
            else if (item.StartsWith("$ cd"))
            {
                var arg = item.Split(' ').Last();
                if (arg == "..")
                    activeDir = activeDir.Parent!;
                else
                    activeDir = activeDir.GotoChild(arg);
            }
            else
            {
                var contentLength = long.Parse(item.Split(' ')!.First());
                activeDir.AddContentLength(contentLength);
            }
        }

        return directories;
    }

    public override string SolveFirst(string input)
    {
        Dictionary<string, PuzzleDirectory> directories = CreateDictionaries(input);

        return directories.Values
            .Where(d => d.ContentLength < 100000)
            .Sum(d => d.ContentLength)
            .ToString();
    }

    public override string SolveSecond(string input)
    {
        Dictionary<string, PuzzleDirectory> directories = CreateDictionaries(input);
        long missingSpace = - 70000000 + 30000000 + directories["/"].ContentLength;
        return directories.Values
            .Where(d => d.ContentLength > missingSpace)
            .Min(d => d.ContentLength)
            .ToString();
    }
}
