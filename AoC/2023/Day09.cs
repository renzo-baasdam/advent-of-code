using MathNet.Numerics.Distributions;
using System.Numerics;
using Tools.Geometry;

namespace AoC_2023;

public sealed class Day09 : Day
{
    [Puzzle(answer: null)]
    public int Part1Example() => Part1(InputExample);

    [Puzzle(answer: null)]
    public int Part1() => Part1(Input);

    Direction[] dirs = [
        Direction.N,
        Direction.S,
        Direction.W,
        Direction.E,
        Direction.NW,
        Direction.SW,
        Direction.SE,
        Direction.NE];

    public int Part1(string[] input)
    {
        int result = 0;
        var parse = input.Select(x =>
        {
            var split1 = x.Split("", StringSplitOptions.None);
            var split2 = x.Split("", StringSplitOptions.None);
            var split3 = x.Split("", StringSplitOptions.None);
            var kv = new KeyValuePair<string, string>(split1[0], split2[0]);
            return x;
        });
        var board = input.AddBorder('*');
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
            }
        }
        var current = new List<Point>() { new Point(1,1) };
        var visited = new HashSet<Point>();
        int dist = 0;
        while (current.Count > 0)
        {
            var next = new List<Point>();
            foreach (var curr in current)
            {
                if (visited.Contains(curr) || board[curr.X][curr.Y] == '*') continue;
                if (board[curr.X][curr.Y] == 'X') return dist;
                next.AddRange(dirs.Select(x => curr.NeighborV(x)));
                visited.Add(curr);
            }
            current = next;
            dist++;
        }
        return dist;
    }

    [Puzzle(answer: null)]
    public int Part2Example() => Part2(InputExample);

    [Puzzle(answer: null)]
    public int Part2() => Part2(Input);

    public int Part2(string[] input)
    {
        int result = 0;
        var parse = input.Select(x =>
        {
            var split1 = x.Split("", StringSplitOptions.None);
            var split2 = x.Split("", StringSplitOptions.None);
            var split3 = x.Split("", StringSplitOptions.None);
            var kv = new KeyValuePair<string, string>(split1[0], split2[0]);
            return x;
        });
        return result;
    }

}