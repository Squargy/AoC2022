using AdventOfCodeLib.SupplyStacks;

namespace AdventOfCodeLib.Days;

internal class Day5 : Day
{
    public Day5(DayContext context) : base(context)
    {
    }

    private (DockStacks, IEnumerable<ArrangementOrder>) ParseInput(string input)
    {
        var splitted = input.Split(Environment.NewLine + Environment.NewLine);
        var dockStacks = new DockStacks(splitted.First().Split(Environment.NewLine));
        var arrangementOrders = splitted.Last().Split(Environment.NewLine).Select(l => new ArrangementOrder(l));

        return (dockStacks, arrangementOrders);
    }

    protected override string FirstSolutionLogic(string input)
    {
        var (dockStacks, orders) = ParseInput(input);

        foreach (var order in orders)
        {
            dockStacks.Move1(order.Number, order.From, order.To);
        }
        
        return dockStacks.Message();
    }

    protected override string SecondSolutionLogic(string input)
    {
        var (dockStacks, orders) = ParseInput(input);

        foreach (var order in orders)
        {
            dockStacks.Move2(order.Number, order.From, order.To);
        }

        return dockStacks.Message();
    }
}