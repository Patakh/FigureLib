namespace FigureLib;
 
public class Triangle : IFigure
{
    private double _height;
    private double _basis;
    public Triangle(double height, double basis)
    {
        _basis = basis;
        _height = height;
    }
    public double Area() => 0.5 * _basis * _height;
    public bool IsRightTriangle()
    { 
        double baseSquare = _basis * _basis;
        double heightSquare = _height * _height;
        double hypothenuseSquare = baseSquare + heightSquare; 
        return Math.Abs(hypothenuseSquare - heightSquare) < double.Epsilon;
    }
}