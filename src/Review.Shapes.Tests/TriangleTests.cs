using FluentAssertions;

namespace Review.Shapes.Tests;

[TestFixture]
public class TriangleTests
{
    public static object[] NotRectangularTriangles =
    {
        new double[] {6, 4, 5},
        new double[] {12, 13, 20},
        new double[] {5, 8, 10},
    };
    public static object[] RectangularTriangles =
    {
        new double[] {3, 4, 5},
        new double[] {9, 12, 15},
    };

    [Test]
    [TestCaseSource(nameof(NotRectangularTriangles))]
    [TestCaseSource(nameof(RectangularTriangles))]
    public void AreaTest(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var halfPerimeter = (a + b + c) / 2;
        var area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        triangle.Area.Should().Be(area);
    }

    [Test]
    [TestCaseSource(nameof(NotRectangularTriangles))]
    public void IsNotRectangularTest(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        triangle.IsRectangular.Should().BeFalse();
    }

    [Test]
    [TestCaseSource(nameof(RectangularTriangles))]
    public void IsRectangularTest(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        triangle.IsRectangular.Should().BeTrue();
    }

    [Test]
    [TestCaseSource(nameof(NotRectangularTriangles))]
    [TestCaseSource(nameof(RectangularTriangles))]
    public void PerimeterTest(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        triangle.Perimeter.Should().Be(a + b + c);
    }
}