namespace Review.Shapes;

public record struct Rectangle(double A, double B) : IShape
{
    public double Area { get; } = A * B;
}