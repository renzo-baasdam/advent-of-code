using System.Collections;

namespace Tools.Shapes;

public static class Intervals
{
    public static HashSet<Interval1D> Simplify(HashSet<Interval1D> Set)
    {
        var sorted = Set.OrderBy(interval => interval.Start).ToList();
        var simplified = new HashSet<Interval1D>();
        int index = 0;

        while (index < sorted.Count)
        {
            long start = sorted[index].Start;
            long end = sorted[index].End;

            ++index;
            while (index < sorted.Count && sorted[index].Start <= end)
            {
                end = Math.Max(end, sorted[index].End);
                ++index;
            }
            simplified.Add(new Interval1D(start, end));
        }

        return simplified;
    }

}