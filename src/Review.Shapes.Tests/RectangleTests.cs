using FluentAssertions;

namespace Review.Shapes.Tests;

[TestFixture]
public class RectangleTests
{
    public static object[] Rectangles =
    {
        new double[] {5, 5},
        new double[] {1, 9},
        new double[] {10, 3},
    };

    [Test]
    [TestCaseSource(nameof(Rectangles))]
    public void AreaTest(double a, double b)
    {
        var rectangle = new Rectangle(a, b);
        rectangle.Area.Should().Be(a * b);
    }
}