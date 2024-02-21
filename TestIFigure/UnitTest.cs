using FigureLib;

namespace TestIFigure;
public class UnitTest
{
    [Fact]
    public void TestCircleArea()
    {
        // Arrange
        double radius = 5;
        IFigure figure = new Circle(radius);

        // Act
        double expectedArea = Math.PI * radius * radius;
        double actualArea = figure.Area();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void TestSquareArea()
    {
        // Arrange
        double side = 62;
        IFigure figure = new Square(side);

        // Act
        double expectedArea = side * side;
        double actualArea = figure.Area();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void TestIsRightTriangle()
    {
        // Arrange
        double height = 100;
        double basis = 62;
        Triangle figure = new Triangle(height, basis);

        // Act
        double baseSquare = basis * basis;
        double heightSquare = height * height;
        double hypothenuseSquare = baseSquare + heightSquare;
        bool expecteIsRightTriangl = Math.Abs(hypothenuseSquare - heightSquare) < double.Epsilon;  
        bool actualIsRightTriangl =  figure.IsRightTriangle();

        // Assert
        Assert.Equal(expecteIsRightTriangl, actualIsRightTriangl);
    }

    [Fact]
    public void TestTriangleArea()
    {
        // Arrange
        double height = 100;
        double basis = 62;
        IFigure figure = new Triangle(height, basis);

        // Act 
        double expectedArea = 0.5 * basis * height;  
        double actualArea = figure.Area();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }
}