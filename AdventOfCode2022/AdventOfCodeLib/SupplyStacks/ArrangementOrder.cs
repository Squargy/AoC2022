using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCodeLib.SupplyStacks;

public class ArrangementOrder
{
	static readonly Regex regex = new Regex(@"move (\d+) from (\d+) to (\d+)");

	public int Number { get; set; }
	public int From { get; set; }
	public int To { get; set; }

    public ArrangementOrder(string line)
	{
		var match = regex.Match(line);
		Number = int.Parse(match.Groups[1].Value);
        From = int.Parse(match.Groups[2].Value);
        To = int.Parse(match.Groups[3].Value);
	}
}
