using FluentAssertions;

namespace Review.Shapes.Tests;

[TestFixture]
public class CircleTests
{
    public static object[] Circles =
    {
        new double[] {5},
        new double[] {1},
        new double[] {10},
    };

    [Test]
    [TestCaseSource(nameof(Circles))]
    public void AreaTest(double radius)
    {
        var circle = new Circle(radius);
        circle.Area.Should().Be(Math.PI * radius * radius);
    }
}