namespace Lab10_Circle;

public class Circle
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateDiameter()
    {
        return radius * 2;
    }
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public void Grow()
    {
        radius *= 2;
    }
    public double GetRadius()
    {
        return radius;
    }
}
