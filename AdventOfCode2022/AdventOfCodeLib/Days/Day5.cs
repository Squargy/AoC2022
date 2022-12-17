using AdventOfCodeLib.SupplyStacks;

namespace AdventOfCodeLib.Days;

public class Day5 : Day
{
    private (DockStacks, IEnumerable<ArrangementOrder>) ParseInput(string input)
    {
        var splitted = input.Split(Environment.NewLine + Environment.NewLine);
        var dockStacks = new DockStacks(splitted.First().Split(Environment.NewLine));
        var arrangementOrders = splitted.Last().Split(Environment.NewLine).Select(l => new ArrangementOrder(l));

        return (dockStacks, arrangementOrders);
    }

    public override string SolveFirst(string input)
    {
        var (dockStacks, orders) = ParseInput(input);

        foreach (var order in orders)
        {
            dockStacks.Move1(order.Number, order.From, order.To);
        }
        
        return dockStacks.Message();
    }

    public override string SolveSecond(string input)
    {
        var (dockStacks, orders) = ParseInput(input);

        foreach (var order in orders)
        {
            dockStacks.Move2(order.Number, order.From, order.To);
        }

        return dockStacks.Message();
    }
}