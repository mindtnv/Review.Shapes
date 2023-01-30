namespace Review.Shapes;

public record struct Triangle : IShape
{
    public static readonly double Epsilon = 0.0001;
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public double Perimeter { get; }
    public bool IsRectangular { get; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
        IsRectangular = Math.Abs(a * a + b * b - c * c) < Epsilon ||
                        Math.Abs(a * a + c * c - b * b) < Epsilon ||
                        Math.Abs(b * b + c * c - a * a) < Epsilon;
        Perimeter = a + b + c;
        var halfPerimeter = Perimeter / 2;
        Area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    public double Area { get; }
}