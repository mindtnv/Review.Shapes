namespace Review.Shapes;

public record struct Circle(double Radius) : IShape
{
    public double Radius { get; } = Radius;
    public double Area { get; } = Math.PI * Radius * Radius;
}