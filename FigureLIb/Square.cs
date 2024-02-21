namespace FigureLib;
 
public class Square : IFigure
{
    private double _side;
    public Square(double side)
    {
        _side = side;
    }
    public double Area() => _side * _side;
} 