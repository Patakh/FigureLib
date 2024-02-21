namespace FigureLib;

public class Circle : IFigure
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area() => Math.PI * _radius * _radius;
} 