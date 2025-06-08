namespace Tools.Shapes;

public class Interval1DSetTests
{
    [Test]
    public void SimplifiesCorrectly()
    {
        var set = new HashSet<Interval1D>() 
        { 
            new Interval1D(0, 4), new Interval1D(4, 10), new Interval1D(7, 20), new Interval1D(18, 19),
            new Interval1D(1000, 4000)
        };

        var simplified = Intervals.Simplify(set);

        simplified.Should().BeEquivalentTo(new[] {
            new Interval1D(0, 20),
            new Interval1D(1000, 4000)
        });
    }

}