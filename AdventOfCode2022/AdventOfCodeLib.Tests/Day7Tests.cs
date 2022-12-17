namespace AdventOfCodeLib.Tests
{
    public class Day7Tests : DayTestSingleBase<Day7>
    {
        protected override string Input1 => @"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";

        protected override string ExpectedFirstStar => "95437";

        protected override string ExpectedSecondStar => "24933642";
    }
}
